using System.IO;

namespace MobileDevOps.SampleApp.Services
{
    public interface IConfigurationFileProvider
    {
        Stream GetConfigurationStream();
    }
}