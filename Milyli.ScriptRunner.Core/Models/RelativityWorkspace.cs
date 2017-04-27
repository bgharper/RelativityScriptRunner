﻿namespace Milyli.ScriptRunner.Core.Models
{
    using DTOs = kCura.Relativity.Client.DTOs;

    public class RelativityWorkspace
    {
        public RelativityWorkspace()
        {
        }

        public RelativityWorkspace(DTOs.Artifact artifact)
        {
            this.WorkspaceId = artifact.ArtifactID;
        }

        public static RelativityWorkspace AdminWorkspace
        {
            get
            {
                return new RelativityWorkspace()
                {
                    WorkspaceId = -1
                };
            }
        }

        public int WorkspaceId { get; set; }

        public string WorkspaceName { get; set; }
    }
}