using MAUIControlGallery.Services;
using MAUIControlGallery.ViewModels;
using MAUIControlGallery.Views;
using Microsoft.Extensions.Logging;
using Plugin.LocalNotification;

namespace MAUIControlGallery
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseLocalNotification()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<INavigationService, NavigationService>();

            builder.Services.AddTransient<AppShell>();
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<Notification>();

            builder.Services.AddTransient<AppShellViewModel>();
            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddTransient<NotificationViewModel>();

            return builder.Build();
        }
    }
}
