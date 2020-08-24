namespace MobileDevOps.SampleApp.Services
{
    public interface IApplicationSettings
    {
        string ApiBaseUrl { get; }

        string AppCenterKeyForIOS { get; }

        string AppCenterKeyForAndroid { get; }

        string AppCenterLogLevel { get; }
    }
}