using System;
using System.Threading.Tasks;
using Unity;
using Xunit;

using GeneratorProject.Platforms.Backend.PHP;
using System.Collections.Generic;
using Mobioos.Foundation.Prompt;
using Mobioos.Foundation.Prompt.Infrastructure;

namespace GeneratorProject.Tests
{
   public class CommonWorkflowTest : BaseGeneratorTest, IDisposable
    {
        public CommonWorkflowTest() : base()
        {
            _workflowHost.RegisterWorkflow<CommonWorkflow>();
            _container.RegisterType<CommonWritingSteps>();
            _workflowHost.Start();
        }

        [Fact]
        public async Task Execute()
        {
            var answers = new List<Answer>();
            answers.Add(new Answer()
            {
                Name = "DatabaseType",
                Type = AnswerType.Text,
                Value = "mysql"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("DatabaseType", answers);

            var answers1 = new List<Answer>();
            answers.Add(new Answer()
            {
                Name = "DatabaseName",
                Type = AnswerType.Text,
                Value = "phpDatabase"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("DatabaseName", answers1);

            var answers2 = new List<Answer>();
            answers.Add(new Answer()
            {
                Name = "DatabaseHost",
                Type = AnswerType.Text,
                Value = "127.0.0.1"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("DatabaseHost", answers2);

            var answers3 = new List<Answer>();
            answers.Add(new Answer()
            {
                Name = "DatabasePort",
                Type = AnswerType.Text,
                Value = "3306"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("DatabasePort", answers3);

            var answers4 = new List<Answer>();
            answers.Add(new Answer()
            {
                Name = "DatabaseUsername",
                Type = AnswerType.Text,
                Value = "root"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("DatabaseUsername", answers4);

            var answers5 = new List<Answer>();
            answers.Add(new Answer()
            {
                Name = "DatabasePassword",
                Type = AnswerType.Text,
                Value = "password"
            });

            ((IDictionary<string, object>)_context.DynamicContext).Add("DatabasePassword", answers5);

            string workflowId = await _workflowHost.StartWorkflow("CommonWorkflowId", 1);
            WaitForWorkflowToComplete(workflowId, TimeSpan.FromSeconds(30));
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
