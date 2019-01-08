using Mobioos.Foundation.Prompt;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using System.Threading.Tasks;
using System.Collections.Generic;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class MailConfigPromptingSteps : StepBodyAsync
    {
        private readonly IPrompting _promptingService;

        public MailConfigPromptingSteps(IPrompting promptingService)
        {
            _promptingService = promptingService;
        }

        public async override Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            var prompts = GetEMailConfigQuestions();

            await _promptingService.Prompts(nameof(MailConfigPromptingSteps), prompts, "PHP framework: questions for mail configuration");

            return ExecutionResult.Next();
        }

        private Stack<Question> GetEMailConfigQuestions()
        {
            var prompts = new Stack<Question>();

            var emailDrivers = new List<Choice>();
            emailDrivers.Add(new Choice { Key = "smtp", Name = "smtp", Value = "smtp" });
            emailDrivers.Add(new Choice { Key = "sendmail", Name = "sendmail", Value = "sendmail" });
            emailDrivers.Add(new Choice { Key = "mailgun", Name = "mailgun", Value = "mailgun" });
            emailDrivers.Add(new Choice { Key = "mandrill", Name = "mandrill", Value = "mandrill" });
            emailDrivers.Add(new Choice { Key = "ses", Name = "ses", Value = "ses" });
            emailDrivers.Add(new Choice { Key = "sparkpost", Name = "sparkpost", Value = "sparkpost" });
            emailDrivers.Add(new Choice { Key = "log", Name = "log", Value = "log" });
            emailDrivers.Add(new Choice { Key = "array", Name = "array", Value = "array" });

            prompts.Push(new Question
            {
                Name = "EmailFromEmailId",
                Message = "Enter from e-mail id",
                Type = QuestionType.Email
            });

            prompts.Push(new Question
            {
                Name = "EmailPassword",
                Message = "Enter e-mail server password",
                Type = QuestionType.Password
            });

            prompts.Push(new Question
            {
                Name = "EmailUsername",
                Message = "Enter e-mail server username",
                Type = QuestionType.Text
            });


            prompts.Push(new Question
            {
                Name = "EmailPort",
                Message = "Enter e-mail server port number",
                Type = QuestionType.Number
            });

            prompts.Push(new Question
            {
                Name = "EmailHost",
                Message = "Enter e-mail server url",
                Type = QuestionType.Text
            });

            prompts.Push(new ChoiceQuestion
            {
                Name = "EmailDriver",
                Message = "Select e-mail driver",
                Type = QuestionType.Choice,
                Choices = emailDrivers
            });

            return prompts;
        }
    }
}
