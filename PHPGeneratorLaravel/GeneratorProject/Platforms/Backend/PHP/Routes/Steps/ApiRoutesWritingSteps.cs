﻿using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Contexts;
using Mobioos.Scaffold.BaseInfrastructure.Notifiers;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using Mobioos.Foundation.Prompt;
using WorkflowCore.Interface;
using WorkflowCore.Models;

using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class ApiRoutesWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public ApiRoutesWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
        {
            _context = context;
            _writingService = writingService;
            _workflowNotifier = workflowNotifier;
        }

        public override Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            if (null == _context.Manifest)
                throw new ArgumentNullException(nameof(_context.Manifest));

            SmartAppInfo smartApp = _context.Manifest;

            _workflowNotifier.Notify(nameof(ApiRoutesWritingSteps), NotificationType.GeneralInfo, "Generating PHP api routes");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                TransformApiRoutes(smartApp);

            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformApiRoutes(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.Api != null)
            {
                string controllerSuffix = GetControllerSuffix();

                ApiRoutesTemplate apiTemplate = new ApiRoutesTemplate(smartApp, controllerSuffix);

                _writingService.WriteFile(Path.Combine(_context.BasePath, apiTemplate.OutputPath), apiTemplate.TransformText());
            }
        }

        private string GetControllerSuffix()
        {
            var controllerSuffix = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("ControllerSuffix") ? _context.DynamicContext.ControllerSuffix as List<Answer> : new List<Answer>();
            return (controllerSuffix != null && controllerSuffix.Count > 0) ? controllerSuffix.FirstOrDefault().Value : "Controller";
        }
    }
}
