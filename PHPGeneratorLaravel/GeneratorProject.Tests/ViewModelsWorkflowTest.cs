using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Mobioos.Foundation.Prompt;
using Mobioos.Foundation.Prompt.Infrastructure;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Backend.PHP;

namespace GeneratorProject.Tests
{
    public class ViewModelsWorkflowTest : BaseGeneratorTest, IDisposable
    {
        public ViewModelsWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<ViewModelsWorkflow>();
            _container.RegisterType<ViewModelsWritingSteps>();
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

            var answers1 = new List<Answer>();
            answers1.Add(new Answer()
            {
                Name = "ViewModelSuffix",
                Type = AnswerType.Text,
                Value = "ViewModel"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("ViewModelSuffix", answers1);

            string workflowId = await _workflowHost.StartWorkflow("ViewModelsWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
