using Mobioos.Foundation.Jade;
using Mobioos.Scaffold.Core.Runtime;
using Mobioos.Scaffold.Infrastructure.Runtime;
using System.IO;
using System.Threading.Tasks;
using GeneratorProject.Platforms.Backend.PHP;
using Xunit;
using System;

namespace GeneratorProject.Tests
{
    public class ModelsActivityTest: BaseGeneratorTest, IDisposable
    {
        public ModelsActivityTest() : base()
        {
        }

        [Fact]
        public async Task Execute()
        {
            var basePath = Path.Combine(Path.GetTempPath(), _context.DynamicContext.Manifest.Id);
            ModelsActivity activity = new ModelsActivity("ModelsActivity", basePath);
            await activity.Initializing(_context);
            await activity.Writing();
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
