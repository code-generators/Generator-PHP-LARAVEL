using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Backend.PHP
{
    [WorkFlow(Id = "ViewModelsWorkflowId", Order = 5)]
    public class ViewModelsWorkflow : IWorkflow
    {
        public string Id => "ViewModelsWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<ViewModelsWritingSteps>()
                .Then<WorkFlowEndStepBase>();
        }
    }
}


