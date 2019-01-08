using Mobioos.Foundation.Prompt;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using System.Threading.Tasks;
using System.Collections.Generic;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class SessionDriverConfigPromptingStep: StepBodyAsync
    {
        private readonly IPrompting _promptingService;

        public SessionDriverConfigPromptingStep(IPrompting promptingService)
        {
            _promptingService = promptingService;
        }

        public async override Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            var prompts = GetSessionDriverConfigQuestions();

            await _promptingService.Prompts(nameof(SessionDriverConfigPromptingStep), prompts, "PHP framework: questions for session storage driver configuration");

            return ExecutionResult.Next();
        }

        private Stack<Question> GetSessionDriverConfigQuestions()
        {
            var prompts = new Stack<Question>();

            var sessionDrivers = new List<Choice>();
            //sessionDrivers.Add(new Choice { Key = "file", Name = "file", Value = "file" });
            sessionDrivers.Add(new Choice { Key = "cookie", Name = "cookie", Value = "cookie" });
            sessionDrivers.Add(new Choice { Key = "database", Name = "database", Value = "database" });
            //sessionDrivers.Add(new Choice { Key = "apc", Name = "apc", Value = "apc" });
            sessionDrivers.Add(new Choice { Key = "memcached", Name = "memcached", Value = "memcached" });
            sessionDrivers.Add(new Choice { Key = "redis", Name = "redis", Value = "redis" });
            //sessionDrivers.Add(new Choice { Key = "array", Name = "array", Value = "array" });

            var expireOnClose = new List<Choice>();
            expireOnClose.Add(new Choice { Key = "expireOnCloseYes", Name = "expireOnCloseYes", Value = "expireOnCloseYes" });
            expireOnClose.Add(new Choice { Key = "expireOnCloseNo", Name = "expireOnCloseNo", Value = "expireOnCloseNo" });

            var sessionEncrypted = new List<Choice>();
            sessionEncrypted.Add(new Choice { Key = "sessionEncryptedYes", Name = "sessionEncryptedYes", Value = "sessionEncryptedYes" });
            sessionEncrypted.Add(new Choice { Key = "sessionEncryptedNo", Name = "sessionEncryptedNo", Value = "sessionEncryptedNo" });

            prompts.Push(new ChoiceQuestion
            {
                Name = "SessionEncryption",
                Message = "Encrypt session data",
                Type = QuestionType.Choice,
                Choices = sessionEncrypted

            });

            prompts.Push(new ChoiceQuestion
            {
                Name = "SessionExpireOnClose",
                Message = "Session expire on close",
                Type = QuestionType.Choice,
                Choices = expireOnClose

            });

            prompts.Push(new Question
            {
                Name = "SessionLifetime",
                Message = "Enter session lifetime in minutes",
                Type = QuestionType.Number
            });

            prompts.Push(new ChoiceQuestion
            {
                Name = "SessionDriver",
                Message = "Select session driver",
                Type = QuestionType.Choice,
                Choices = sessionDrivers
            });

            return prompts;
        }
    }
}
