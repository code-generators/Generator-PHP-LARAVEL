using System.IO;
using System.Threading.Tasks;
using Xunit;
using System;

using GeneratorProject.Platforms.Backend.PHP;

namespace GeneratorProject.Tests
{
    public class RoutesActivityTest: BaseGeneratorTest, IDisposable
    {
        [Fact]
        public async Task Execute()
        {
            var basePath = Path.Combine(Path.GetTempPath(), _context.DynamicContext.Manifest.Id);
            RoutesActivity activity = new RoutesActivity("RoutesActivity", basePath);
            await activity.Initializing(_context);
            await activity.Writing();
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
