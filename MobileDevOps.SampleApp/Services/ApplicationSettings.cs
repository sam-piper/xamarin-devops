using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace MobileDevOps.SampleApp.Services
{
    public class ApplicationSettings : IApplicationSettings
    {
        private readonly JObject _settings;

        public ApplicationSettings(IConfigurationFileProvider configurationFileProvider)
        {
            using (var reader = new StreamReader(configurationFileProvider.GetConfigurationStream()))
            {
                var json = reader.ReadToEnd();
                _settings = JObject.Parse(json);
            }
        }

        public string ApiBaseUrl => GetSetting<string>(nameof(ApiBaseUrl));

        public string AppCenterKeyForIOS => GetSetting<string>("AppCenterKeys.iOS");

        public string AppCenterKeyForAndroid => GetSetting<string>("AppCenterKeys.Android");

        public string AppCenterLogLevel => GetSetting<string>(nameof(AppCenterLogLevel));

        private T GetSetting<T>(string key)
        {
            var value = _settings.SelectToken(key);
            if (value == null)
            {
                throw new InvalidOperationException($"Key '{key}' does not exist in current settings file.");
            }

            return value.Value<T>();
        }
    }
}