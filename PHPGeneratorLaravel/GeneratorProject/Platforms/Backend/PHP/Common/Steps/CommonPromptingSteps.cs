using Mobioos.Foundation.Prompt;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using System.Threading.Tasks;
using System.Collections.Generic;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class CommonPromptingSteps : StepBodyAsync
    {
        private readonly IPrompting _promptingService;

        public CommonPromptingSteps(IPrompting promptingService)
        {
            _promptingService = promptingService;
        }

        public async override Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            var prompts = new Stack<Question>();
            
            prompts.Push(new ChoiceQuestion()
            {
                Name = "DatabaseType",
                Message = "Select database type",
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
                Name = "DatabaseHost",
                Message = "Enter database host",
                Type = QuestionType.Text
            });

            prompts.Push(new Question
            {
                Name = "DatabasePort",
                Message = "Enter database port number",
                Type = QuestionType.Text
            });

            prompts.Push(new Question
            {
                Name = "DatabaseUsername",
                Message = "Enter database username",
                Type = QuestionType.Text
            });

            prompts.Push(new Question
            {
                Name = "DatabasePassword",
                Message = "Enter database password",
                Type = QuestionType.Text
            });

           await _promptingService.Prompts(nameof(CommonPromptingSteps), prompts, "PHP framework: questions for common files");

            return ExecutionResult.Next();
        }
    }
}
