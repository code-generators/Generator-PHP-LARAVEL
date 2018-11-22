﻿using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Backend.PHP
{
    [WorkFlow(Id = "CommonWorkflowId", Order = 1)]
    public class CommonWorkflow : IWorkflow
    {
        public string Id => "CommonWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<CommonPromptingSteps>()
                 .WaitForAnswers(nameof(CommonPromptingSteps))
                 .Then<CommonWritingSteps>()
                 .Then<WorkFlowEndStepBase>();
        }
    }
}
