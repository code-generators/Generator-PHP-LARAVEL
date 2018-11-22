using System;
using System.Threading.Tasks;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Backend.PHP;

namespace GeneratorProject.Tests
{
    public class ViewsWorkflowTest : BaseGeneratorTest, IDisposable
    { 
        public ViewsWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<ViewsWorkflow>();
            _container.RegisterType<ViewsWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            string workflowId = await _workflowHost.StartWorkflow("ViewsWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
