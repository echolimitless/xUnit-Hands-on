using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace AsyncAwait.Tests
{
    public class FilesTests : IDisposable
    {
        private const string ExistFileName = "test.txt";
        private const string TextFileContent = "Hello, xUnit.net!";
        private const string NotExistFileName = "NotExistFile";

        public FilesTests()
        {
            if (File.Exists(ExistFileName))
                File.Delete(ExistFileName);

            File.WriteAllText(ExistFileName, TextFileContent);
        }

        public void Dispose()
        {
            if (File.Exists(ExistFileName))
                File.Delete(ExistFileName);
        }

        [Fact]
        public async Task ReadAllTextAsyncWhenExistFile()
        {
            Assert.Equal(TextFileContent, await Files.ReadAllTextAsync(ExistFileName));
        }

        [Fact]
        public async Task ReadAllTextAsyncWhenNotExistFile()
        {
            await Assert.ThrowsAsync<FileNotFoundException>(
                () => Files.ReadAllTextAsync(NotExistFileName));
        }
    }
}
