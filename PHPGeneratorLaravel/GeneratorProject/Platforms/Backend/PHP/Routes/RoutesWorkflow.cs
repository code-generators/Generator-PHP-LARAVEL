using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Backend.PHP
{
    [WorkFlow(Id = "RoutesWorkflowId", Order = 4)]
    public class RoutesWorkflow : IWorkflow
    {
        public string Id => "RoutesWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<RoutesPromptingSteps>()
                 .WaitForAnswers(nameof(RoutesPromptingSteps))
                 .Then<ApiRoutesWritingSteps>()
                 .Then<WebRoutesWritingSteps>()
                 .Then<WorkFlowEndStepBase>();
        }
    }
}
