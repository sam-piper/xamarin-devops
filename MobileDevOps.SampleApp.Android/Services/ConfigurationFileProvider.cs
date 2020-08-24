using System.IO;
using Android.App;
using MobileDevOps.SampleApp.Services;

namespace MobileDevOps.SampleApp.Droid.Services
{
    public class ConfigurationFileProvider : IConfigurationFileProvider
    {
        public Stream GetConfigurationStream()
        {
            return Application.Context.Assets.Open("appsettings.json");
        }
    }
}