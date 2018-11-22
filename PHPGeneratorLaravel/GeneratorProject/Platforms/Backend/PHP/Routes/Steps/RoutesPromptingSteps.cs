using Mobioos.Foundation.Prompt;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using WorkflowCore.Interface;
using WorkflowCore.Models;

using System.Threading.Tasks;
using System.Collections.Generic;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class RoutesPromptingSteps : StepBodyAsync
    {
        private readonly IPrompting _promptingService;

        public RoutesPromptingSteps(IPrompting promptingService)
        {
            _promptingService = promptingService;
        }

        public async override Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            var prompts = new Stack<Question>();

            prompts.Push(new Question
            {
                Name = "ControllerSuffix",
                Message = "Enter suffix for controller",
                Type = QuestionType.Text
            });

            await _promptingService.Prompts(nameof(RoutesPromptingSteps), prompts, "PHP framework: questions for Api and web routes");

            return ExecutionResult.Next();
        }
    }
}
