using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class DatabaseConfigInfo
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
