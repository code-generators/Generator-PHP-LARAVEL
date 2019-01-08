using Mobioos.Foundation.Prompt;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using System.Threading.Tasks;
using System.Collections.Generic;
using WorkflowCore.Interface;
using WorkflowCore.Models;
using Mobioos.Scaffold.BaseInfrastructure.Contexts;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class SessionConfigPromptingStep : StepBodyAsync
    {
        private readonly IPrompting _promptingService;
        private readonly ISessionContext _context;

        public SessionConfigPromptingStep(ISessionContext context, IPrompting promptingService)
        {
            _context = context;
            _promptingService = promptingService;
        }

        public async override Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            var prompts = new Stack<Question>();

            var sessionDriver = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("SessionDriver") ? _context.DynamicContext.SessionDriver as List<Answer> : new List<Answer>();

            switch (sessionDriver[0].Name.ToLower())
            {
                case "database":
                    prompts = GetDatabaseConfigQuestions();
                    break;
                case "redis":
                    prompts = GetRedisConfigQuestions();
                    break;
                case "memcached":
                    prompts = GetMemCacheConfigQuestions();
                    break;
                case "cookie":
                    prompts = GetCockieConfigQuestions();
                    break;
            }

            await _promptingService.Prompts(nameof(SessionConfigPromptingStep), prompts, "PHP framework: questions for session storage configuration");

            return ExecutionResult.Next();
        }

        private Stack<Question> GetDatabaseConfigQuestions()
        {
            var prompts = new Stack<Question>();

            var databaseChoices = new List<Choice>();

            databaseChoices.Add(new Choice { Key = "sqlite", Name = "sqlite", Value = "sqlite" });
            databaseChoices.Add(new Choice { Key = "mysql", Name = "mysql", Value = "mysql" });
            databaseChoices.Add(new Choice { Key = "pgsql", Name = "pgsql", Value = "pgsql" });
            databaseChoices.Add(new Choice { Key = "sqlsrv", Name = "sqlsrv", Value = "sqlsrv" });

            prompts.Push(new Question()
            {
                Name = "SessionTable",
                Message = "Enter session table name",
                Type = QuestionType.Text,
                
            });

            prompts.Push(new ChoiceQuestion()
            {
                Name = "SessionDatabaseType",
                Message = "Select session database type",
                Type = QuestionType.Choice,
                Choices = databaseChoices
            });

            return prompts;
        }

        private Stack<Question> GetMemCacheConfigQuestions()
        {
            var prompts = new Stack<Question>();

            prompts.Push(new Question
            {
                Name = "MemCachePassword",
                Message = "Enter MemCache password",
                Type = QuestionType.Password
            });

            prompts.Push(new Question
            {
                Name = "MemCacheUsername",
                Message = "Enter MemCache username",
                Type = QuestionType.Text
            });

            prompts.Push(new Question
            {
                Name = "MemCachePort",
                Message = "Enter MemCache port number",
                Type = QuestionType.Number
            });

            prompts.Push(new Question
            {
                Name = "MemCacheHost",
                Message = "Enter MemCache host",
                Type = QuestionType.Text
            });

            prompts.Push(new Question
            {
                Name = "MemCachePersistentId",
                Message = "Enter MemCache Persistent Id",
                Type = QuestionType.Identifier
            });

            return prompts;
        }

        private Stack<Question> GetRedisConfigQuestions()
        {
            var prompts = new Stack<Question>();

            prompts.Push(new Question
            {
                Name = "RedisPassword",
                Message = "Enter redis database password",
                Type = QuestionType.Password
            });

            prompts.Push(new Question
            {
                Name = "RedisPort",
                Message = "Enter redis database port number",
                Type = QuestionType.Number
            });

            prompts.Push(new Question
            {
                Name = "RedisHost",
                Message = "Enter redis database host",
                Type = QuestionType.Text
            });

            return prompts;
        }

        private Stack<Question> GetCockieConfigQuestions()
        {
            var prompts = new Stack<Question>();

            prompts.Push(new Question
            {
                Name = "SessionCookieDomainName",
                Message = "Enter session cookie domain name",
                Type = QuestionType.Text
            });

            prompts.Push(new Question
            {
                Name = "SessionCookiePath",
                Message = "Enter session cookie path",
                Type = QuestionType.Text
            });

            prompts.Push(new Question
            {
                Name = "SessionCookieName",
                Message = "Enter session cookie name",
                Type = QuestionType.Text
            });

            
            return prompts;
        }
    }
}
