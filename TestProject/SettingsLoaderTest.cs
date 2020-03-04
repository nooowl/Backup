using BackupFile.Settings;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class SettingsLoaderTest
    {
        private bool IsNull(Settings settings)
        {
            return settings.SourceDirectories != null &&
                   settings.TargetDirectory != null;
        }
        
        [Test]
        [TestCase(@"TestResources\Settings.json")]
        public void GoodLoad(string jsonFile)
        {
            var settings = new JsonSettingsLoader().Load(jsonFile);
            Assert.IsTrue(IsNull(settings));
        }

        [Test]
        [TestCase(@"TestResources\BadSettings.json")]
        public void BadLoad(string jsonFile)
        {
            var settings = new JsonSettingsLoader().Load(jsonFile);
            Assert.IsFalse(IsNull(settings));
        }
        
        [Test]
        [TestCase(@"TestResources\TxtSettings.txt")]
        public void TxtLoad(string jsonFile)
        {
            Assert.That(() => { new JsonSettingsLoader().Load(jsonFile); }, 
                Throws.Exception);
            
        }
    }
}