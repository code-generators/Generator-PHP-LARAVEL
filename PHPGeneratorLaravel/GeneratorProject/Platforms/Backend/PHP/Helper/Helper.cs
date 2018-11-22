using Mobioos.Scaffold.BaseGenerators.Helpers;
using System.Text.RegularExpressions;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public static class Helper
    {
        public static string WordSeperator(string input)
        {
            return Regex.Replace(TextConverter.PascalCase(input), "([A-Z])", " $1", RegexOptions.Compiled).Trim();
        }
    }
}
