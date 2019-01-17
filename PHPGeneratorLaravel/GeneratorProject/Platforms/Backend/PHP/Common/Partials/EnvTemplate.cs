using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class EnvTemplate : TemplateBase
    {
        private DatabaseConfigInfo _databaseConfigInfo { get; set; }
        private RedisConfigInfo _redisConfigInfo { get; set; }
        private MailConfigInfo _mailConfigInfo { get; set; }
        private SessionConfigInfo _sessionConfigInfo { get; set; }
        private CockieConfigInfo _cockieConfigInfo { get; set; }
        private MemCachedConfigInfo _memCachedConfigInfo { get; set; }

        private string _appKey { get; set; }

        public EnvTemplate(string applicationId, DatabaseConfigInfo databaseConfigInfo,
                           RedisConfigInfo redisConfigInfo, MailConfigInfo mailConfigInfo,
                           SessionConfigInfo sessionConfigInfo, CockieConfigInfo cockieConfigInfo,
                           MemCachedConfigInfo memCachedConfigInfo) : base(null, applicationId)
        {
            _databaseConfigInfo = databaseConfigInfo;
            _redisConfigInfo = redisConfigInfo;
            _mailConfigInfo = mailConfigInfo;
            _sessionConfigInfo = sessionConfigInfo;
            _cockieConfigInfo = cockieConfigInfo;
            _memCachedConfigInfo = memCachedConfigInfo;

            _appKey = System.Guid.NewGuid().ToString("N");
        }

        public override string OutputPath => ".env";
    }
}
