using Fast_typing_App;
using Fast_typing_App.Database;
using Fast_typing_App.Database.File;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Xunit.Abstractions;

namespace FastTyping
{
    public class FileIntegration
    {
        public ITestOutputHelper console;
        public FileIntegration(ITestOutputHelper helper) => console = helper;

        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public record TestRecordData(string filed_1,string filed_2);
        [Fact]
        public async void Create_And_Get_Data()
        {
            // Arrange
            TestRecordData data = new(Path.GetRandomFileName(), Path.GetRandomFileName());
            ITargetText fileIntegration = new FileConnecteur(new Uri(path));
            var createdFileName = string.Concat("t_", Path.GetRandomFileName());
            var expectedFilePath = Path.Combine(path,string.Concat(createdFileName, ".json"));

            // Act
            await fileIntegration.CreateForceObjectAsync<TestRecordData>(createdFileName, data);
            var result = await fileIntegration.GetObjectAsync<TestRecordData>(createdFileName);
            w($"path: {path}, createdFile: {createdFileName}");
            w($"object {data}");
            w($"expected path:{expectedFilePath}");
            
            // Assert
            Assert.True(File.Exists(Path.Combine(path, createdFileName + ".json")));
            Assert.Equal(data.filed_1, result.filed_1);
            Assert.Equal(data.filed_2, result.filed_2);
        }

        public void w(string value )
        {
            console.WriteLine(value);
        }

    }
}