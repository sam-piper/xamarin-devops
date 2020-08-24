using MobileDevOps.SampleApp.Services;
using Prism.Navigation;

namespace MobileDevOps.SampleApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService, IApplicationSettings applicationSettings)
            : base(navigationService, applicationSettings)
        {
            Title = "Main Page";
        }
    }
}
