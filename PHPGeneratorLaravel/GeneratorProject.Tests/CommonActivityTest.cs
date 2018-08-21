using System.IO;
using System.Threading.Tasks;
using GeneratorProject.Platforms.Backend.PHP;
using Xunit;
using System;


namespace GeneratorProject.Tests
{
   public class CommonActivityTest : BaseGeneratorTest, IDisposable
    {
        public CommonActivityTest() : base()
        {
        }

        [Fact]
        public async Task Execute()
        {
            var basePath = Path.Combine(Path.GetTempPath(), _context.DynamicContext.Manifest.Id);
            CommonActivity activity = new CommonActivity("CommonActivity", basePath);
            await activity.Initializing(_context);
            await activity.Writing();
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
