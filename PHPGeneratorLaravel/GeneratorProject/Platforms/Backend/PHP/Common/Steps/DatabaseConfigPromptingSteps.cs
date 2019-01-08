using Mobioos.Foundation.Prompt;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using System.Threading.Tasks;
using System.Collections.Generic;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class DatabaseConfigPromptingSteps : StepBodyAsync
    {
        private readonly IPrompting _promptingService;

        public DatabaseConfigPromptingSteps(IPrompting promptingService)
        {
            _promptingService = promptingService;
        }

        public async override Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            var prompts = new Stack<Question>();

            var databaseChoices = new List<Choice>();

            databaseChoices.Add(new Choice { Key = "sqlite", Name = "sqlite", Value = "sqlite" });
            databaseChoices.Add(new Choice { Key = "mysql", Name = "mysql", Value = "mysql" });
            databaseChoices.Add(new Choice { Key = "pgsql", Name = "pgsql", Value = "pgsql" });
            databaseChoices.Add(new Choice { Key = "sqlsrv", Name = "sqlsrv", Value = "sqlsrv" });
            databaseChoices.Add(new Choice { Key = "mongo", Name = "mongo", Value = "mongo" });

            prompts.Push(new Question
            {
                Name = "DatabasePassword",
                Message = "Enter database password",
                Type = QuestionType.Password
            });

            prompts.Push(new Question
            {
                Name = "DatabaseUsername",
                Message = "Enter database username",
                Type = QuestionType.Text
            });

            prompts.Push(new Question
            {
                Name = "DatabaseName",
                Message = "Enter database name",
                Type = QuestionType.Text
            });

            prompts.Push(new Question
            {
                Name = "DatabasePort",
                Message = "Enter database port number",
                Type = QuestionType.Number
            });

            prompts.Push(new Question
            {
                Name = "DatabaseHost",
                Message = "Enter database host",
                Type = QuestionType.Text
            });

            prompts.Push(new ChoiceQuestion()
            {
                Name = "DatabaseType",
                Message = "Select database type",
                Type = QuestionType.Choice,
                Choices = databaseChoices
            });

            await _promptingService.Prompts(nameof(DatabaseConfigPromptingSteps), prompts, "PHP framework: questions for database configuration");

            return ExecutionResult.Next();
        }
    }
}
