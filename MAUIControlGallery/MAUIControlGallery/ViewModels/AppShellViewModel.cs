using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIControlGallery.Services;
using MAUIControlGallery.Views;

namespace MAUIControlGallery.ViewModels
{
    public partial class AppShellViewModel : ObservableObject
    {
        public AppShellViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [RelayCommand]
        private async Task HelpAndSupportClick()
        {
            await _navigationService.NavigateWithoutRootAsync(nameof(HelpAndSupport));
        }

        [RelayCommand]
        private async Task UPIPaymentSettingsClick()
        {
            await _navigationService.NavigateWithoutRootAsync(nameof(UPIPaymentSettings));
        }

        [RelayCommand]
        private async Task OrdersAndBookingsClick()
        {
            await _navigationService.NavigateWithoutRootAsync(nameof(OrdersAndBooking));
        }

        [RelayCommand]
        private void LogOut()
        {

        }

        private readonly INavigationService _navigationService;
    }
}
