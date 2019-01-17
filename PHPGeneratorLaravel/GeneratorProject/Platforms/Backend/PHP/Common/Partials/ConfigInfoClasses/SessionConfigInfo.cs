using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class SessionConfigInfo
    {
        public string Driver { get; set; }
        public string Lifttime { get; set; }
        public string ExpireOnClose { get; set; }
        public string Encrypt { get; set; }
        public string Table { get; set; }
    }
}
