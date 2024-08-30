using MAUIControlGallery.Services;
using MAUIControlGallery.ViewModels;

namespace MAUIControlGallery
{
    public partial class AppShell : Shell
    {
        public AppShell(INavigationService navigationService)
        {
            InitializeComponent();
            BindingContext = new AppShellViewModel(navigationService);
        }
    }
}
