using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIControlGallery.ViewModels
{
    public partial class NotificationViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task GetNotification()
        {
            //if (await LocalNotificationCenter.Current.AreNotificationsEnabled() == false)
            //{
            //    await LocalNotificationCenter.Current.RequestNotificationPermission();
            //}
            var request = new NotificationRequest
            {
                NotificationId = 1,
                Title = "Subcribe to my channel",
                Subtitle = "Hello",
                Description = "How are you?",
                BadgeNumber = 42,
                //CategoryType = NotificationCategoryType.Reminder,
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(2),
                    NotifyRepeatInterval = TimeSpan.FromSeconds(10)
                },
            };

            await LocalNotificationCenter.Current.Show(request);
        }
    }
}
