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
    public class ControllersWorkflowTest : BaseGeneratorTest, IDisposable
    {
        public ControllersWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<ControllersWorkflow>();
            _container.RegisterType<ApiControllersWritingSteps>();
            _container.RegisterType<WebControllersWritingSteps>();
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
                Name = "ControllerSuffix",
                Type = AnswerType.Text,
                Value = "Controller"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("ControllerSuffix", answers1);

            string workflowId = await _workflowHost.StartWorkflow("ControllersWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
