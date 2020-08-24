using System.IO;
using Foundation;
using MobileDevOps.SampleApp.Services;

namespace MobileDevOps.SampleApp.iOS.Services
{
    public class ConfigurationFileProvider : IConfigurationFileProvider
    {
        public Stream GetConfigurationStream()
        {
            var path = NSBundle.MainBundle.PathForResource("appsettings.json", null);
            return File.OpenRead(path);
        }
    }
}