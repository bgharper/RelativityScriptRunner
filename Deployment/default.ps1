Properties {
	$Deployment = Split-Path $psake.build_script_file
	$sln = "$Deployment\..\Solutions\ScriptRunner.sln"
	$Artifacts = "$Deployment\Artifacts"
	$Tools = "$Deployment\Tools"
	$TestResult_xml = "$Deployment\TestResult.xml"
	$BuildTools = "$Tools\BuildTools"
	$nuget_exe = "$Tools\nuget.exe"
	$packages_config = "$Deployment\packages.config"
	$build_xml = "$Deployment\build.xml"
	$nunit_exe = "$BuildTools\NUnit.ConsoleRunner.3.8.0\tools\nunit3-console.exe"
	$rapbuilder_exe = "$BuildTools\RelativityDev.RapBuilder.0.0.0.3-alpha\lib\kCura.RAPBuilder.exe"
}

Task Default -Depends CreateRap

Task PackageBuild {
	Exec { 
		msbuild "$sln" `
			/t:Clean,Rebuild `
			/p:Configuration=Release `
			/v:quiet `
			/p:OutDir=$Artifacts 
	}
}

Task TestBuild {
	Exec { 
		msbuild "$sln" `
			/t:Clean,Rebuild `
			/p:Configuration=Debug `
			/v:quiet `
	}
}

Task RestoreBuildTools -Depends InstallNuget -precondition { -Not (Test-Path $BuildTools) } {

	Exec { & $nuget_exe install $packages_config -o $BuildTools }
}

Task InstallNuget -precondition { -Not (Test-Path $nuget_exe) } {

	Invoke-WebRequest -Uri "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe" -OutFile $nuget_exe -ErrorAction Stop
}

Task UnitTest -Depends RestoreBuildTools, TestBuild {
	Exec { & $nunit_exe $sln --result="$TestResult_xml" --where="cat == Unit && cat != Integration && cat != PlatformUnitTest && cat != Explicit && cat != Ignore" --skipnontestassemblies }
}

Task CreateRap -Depends RestoreBuildTools, PackageBuild {
	Exec { & $rapbuilder_exe /source:"$Deployment" /input:"$build_xml" /version:9.6.0.1 }
}
