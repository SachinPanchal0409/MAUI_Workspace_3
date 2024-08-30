using MAUIControlGallery.Services;
using MAUIControlGallery.Views;

namespace MAUIControlGallery
{
    public partial class App : Application
    {
        public App(INavigationService navigationService)
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddBankAccount), typeof(AddBankAccount));
            Routing.RegisterRoute(nameof(Caseback), typeof(Caseback));
            Routing.RegisterRoute(nameof(HelpAndSupport), typeof(HelpAndSupport));
            Routing.RegisterRoute(nameof(Shopping), typeof(Shopping));
            Routing.RegisterRoute(nameof(UPIPaymentSettings), typeof(UPIPaymentSettings));
            Routing.RegisterRoute(nameof(Wealth), typeof(Wealth));
            Routing.RegisterRoute(nameof(OrdersAndBooking), typeof(OrdersAndBooking));
            Routing.RegisterRoute(nameof(FlexLayoutPage), typeof(FlexLayoutPage));
            Routing.RegisterRoute(nameof(Notification), typeof(Notification));

            MainPage = new AppShell(navigationService);
        }
    }
}
