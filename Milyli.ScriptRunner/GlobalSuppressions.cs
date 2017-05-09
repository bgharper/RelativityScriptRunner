﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:File name must match first type name", Justification = "System generated file", Scope = "type", Target = "~T:Milyli.ScriptRunner.MvcApplication")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "type", Justification = "MVC Application Convention", Target = "Milyli.ScriptRunner.MvcApplication")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope= "type", Justification = "Autogenerated DI code", Target = "Milyli.ScriptRunner.DependencyResolution.ControllerConvention")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Milyli.ScriptRunner.DependencyResolution.ControllerConvention.#Process(System.Type,StructureMap.Registry)", Justification = "DI code")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Milyli.ScriptRunner.App_Start.JsonBinder.#CreateModel(System.Web.Mvc.ControllerContext,System.Web.Mvc.ModelBindingContext,System.Type)", Justification = "Json Model binder, must not fail")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Structuremap", Scope = "type", Target = "Milyli.ScriptRunner.App_Start.StructuremapMvc", Justification = "spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Api", Scope = "type", Target = "Milyli.ScriptRunner.WebApiConfig", Justification = "spelled just fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Io", Scope = "type", Target = "Milyli.ScriptRunner.DependencyResolution.IoC", Justification = "Inversion of Control, spelled fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Milyli.ScriptRunner.Models.ScriptListModel.#RelativityScripts", Justification = "viewmodel, serialized to/from JS")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Milyli.ScriptRunner.Models.JobScheduleModel.#JobScriptInputs", Justification = "viewmodel, serialized to/from JS")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Mvc", Justification = "spelled just fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object,System.Object)", Scope = "member", Target = "Milyli.ScriptRunner.Controllers.JobScheduleController.#NewJobScheduleModel(Milyli.ScriptRunner.Core.Models.RelativityScript,Milyli.ScriptRunner.Core.Models.RelativityWorkspace)", Justification = "Inline format")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Milyli.ScriptRunner.Controllers.RelativityScriptController.#Script(System.Int32,System.Int32)", Justification = "Inline format")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Milyli.ScriptRunner.Controllers.RelativityScriptController.#List(System.Nullable`1<System.Int32>)", Justification = "Inline format")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Milyli.ScriptRunner.Controllers.JobScheduleController.#NewSchedule(System.Int32,System.Int32)", Justification = "Inline format")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Milyli.ScriptRunner.Controllers.JobScheduleController.#Index(System.Int32)", Justification = "Inline format")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "type", Target = "Milyli.ScriptRunner.Controllers.ScriptRunnerController", Justification = "Shared base class")]