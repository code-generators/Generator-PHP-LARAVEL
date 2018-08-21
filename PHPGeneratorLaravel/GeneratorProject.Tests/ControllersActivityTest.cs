using System.IO;
using System.Threading.Tasks;
using GeneratorProject.Platforms.Backend.PHP;
using Xunit;
using System;

namespace GeneratorProject.Tests
{
    public class ControllersActivityTest : BaseGeneratorTest, IDisposable
    {
        public ControllersActivityTest() : base()
        {
        }

        [Fact]
        public async Task Execute()
        {
            var basePath = Path.Combine(Path.GetTempPath(), _context.DynamicContext.Manifest.Id);
            ControllersActivity activity = new ControllersActivity("ControllersActivity", basePath);
            await activity.Initializing(_context);
            await activity.Writing();
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
