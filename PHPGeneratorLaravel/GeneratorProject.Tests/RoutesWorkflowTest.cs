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
    public class RoutesWorkflowTest: BaseGeneratorTest, IDisposable
    {
        public RoutesWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<RoutesWorkflow>();
            _container.RegisterType<ApiRoutesWritingSteps>();
            _container.RegisterType<WebRoutesWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            var answers = new List<Answer>();
            answers.Add(new Answer()
            {
                Name = "ControllerSuffix",
                Type = AnswerType.Text,
                Value = "Controller"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("ControllerSuffix", answers);

            string workflowId = await _workflowHost.StartWorkflow("RoutesWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
