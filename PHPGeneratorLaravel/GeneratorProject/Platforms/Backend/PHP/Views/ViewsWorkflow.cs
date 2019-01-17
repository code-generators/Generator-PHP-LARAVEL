using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Backend.PHP
{
    [WorkFlow(Id = "ViewsWorkflowId", Order = 6)]
    public class ViewsWorkflow : IWorkflow
    {
        public string Id => "ViewsWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<ViewsWritingSteps>()
                .Then<WorkFlowEndStepBase>();
        }
    }
}
