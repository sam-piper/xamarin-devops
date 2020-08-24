using MobileDevOps.SampleApp.Services;
using Prism.Mvvm;
using Prism.Navigation;

namespace MobileDevOps.SampleApp.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        private string _title;

        public ViewModelBase(INavigationService navigationService, IApplicationSettings applicationSettings)
        {
            NavigationService = navigationService;
            ApplicationSettings = applicationSettings;
        }
        
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        
        public INavigationService NavigationService { get; }

        public IApplicationSettings ApplicationSettings { get; }

        public virtual void Initialize(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void Destroy()
        {
        }
    }
}
