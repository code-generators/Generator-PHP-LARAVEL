using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Backend.PHP
{
    [WorkFlow(Id = "ControllersWorkflowId", Order = 2)]
    public class ControllersWorkflow : IWorkflow
    {
        public string Id => "ControllersWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<WebControllersWritingSteps>()
                .Then<ApiControllersWritingSteps>()
                .Then<WorkFlowEndStepBase>();
        }
    }
}
