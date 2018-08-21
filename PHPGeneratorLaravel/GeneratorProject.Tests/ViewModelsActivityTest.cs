using System.IO;
using System.Threading.Tasks;
using Xunit;
using System;

using GeneratorProject.Platforms.Backend.PHP;

namespace GeneratorProject.Tests
{
    public class ViewModelsActivityTest : BaseGeneratorTest, IDisposable
    {
        public ViewModelsActivityTest() : base()
        {
        }

        [Fact]
        public async Task Execute()
        {
            var basePath = Path.Combine(Path.GetTempPath(), _context.DynamicContext.Manifest.Id);
            ViewModelsActivity activity = new ViewModelsActivity("ViewModelsActivity", basePath);
            await activity.Initializing(_context);
            await activity.Writing();
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
