using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Foundation.Prompt;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Backend.PHP;

namespace GeneratorProject.Tests
{
    public class ModelsWorkflowTest: BaseGeneratorTest, IDisposable
    {
        public ModelsWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<ModelsWorkflow>();
            _container.RegisterType<ModelMigrationWritingSteps>();
            _container.RegisterType<ModelsWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            var answers = new List<Answer>();
            answers.Add(new Answer()
            {
                Name = "ModelSuffix",
                Type = AnswerType.Text,
                Value = "Model"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("ModelSuffix", answers);

            string workflowId = await _workflowHost.StartWorkflow("ModelsWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
