using System;
using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class EnvTemplate : TemplateBase
    {
        private string _databaseType { get; set; }
        private string _databaseName { get; set; }
        private string _databaseHost { get; set; }
        private string _databasePort { get; set; }
        private string _databaseUsername { get; set; }
        private string _databasePassword { get; set; }
        private string _appKey { get; set; }

        public EnvTemplate(string applicationId, string databaseType, string databaseName,
            string databaseHost, string databasePort, string databaseUsername, string databasePassword) : base(null, applicationId)
        {
            _databaseType = databaseType;
            _databaseName = "product_management"; //databaseName;
            _databaseHost = databaseHost;
            _databasePort = databasePort;
            _databaseUsername = databaseUsername;
            _databasePassword = databasePassword;
            //_appKey = Guid.NewGuid().ToString("N");
            _appKey = "JnlOR1mG5PnikemPOOEuq8ekQN82SBOJ6xVvB9r/kX4=";

        }

        public override string OutputPath => ".env";
    }
}
