using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIControlGallery.Enums;
using MAUIControlGallery.Services;
using MAUIControlGallery.Views;
using Plugin.LocalNotification;
using System.Windows.Input;

namespace MAUIControlGallery.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private IEnumerable<eTopics> topics;

        private eTopics _selectedTopic;
        private readonly INavigationService _navigationService;

        public eTopics SelectedTopic
        {
            get => _selectedTopic;
            set
            {
                if(SetProperty(ref _selectedTopic, value))
                {
                    OpenTopicDetails(value);
                }
            }
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Topics = Enum.GetValues(typeof(eTopics)).Cast<eTopics>().ToList();
        }

        private async void OpenTopicDetails(eTopics topic)
        {
            switch (topic)
            {
                case eTopics.FlexLayout:
                    await _navigationService.NavigateWithoutRootAsync(nameof(FlexLayoutPage));
                    break;
                case eTopics.CarouselView:
                    break;
                case eTopics.RatingBar:
                    break;
                case eTopics.Menu:
                    break;
                case eTopics.Map:
                    break;
                case eTopics.Notification:
                    await _navigationService.NavigateWithoutRootAsync(nameof(Notification));
                    break;
            }
        }

        
    }
}
