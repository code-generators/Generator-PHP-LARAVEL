using Mobioos.Scaffold.BaseGenerators.Steps;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using WorkflowCore.Interface;

namespace GeneratorProject.Platforms.Backend.PHP
{
    [WorkFlow(Id = "ModelsWorkflowId", Order = 3)]
    public class ModelsWorkflow : IWorkflow
    {
        public string Id => "ModelsWorkflowId";
        public int Version => 1;

        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<ModelsPromptingSteps>()
                 .WaitForAnswers(nameof(ModelsPromptingSteps))
                 .Then<ModelMigrationWritingSteps>()
                 .Then<ModelsWritingSteps>()
                 .Then<WorkFlowEndStepBase>();
         }
    }
}
