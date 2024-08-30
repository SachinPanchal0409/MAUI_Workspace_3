using MAUIControlGallery.ViewModels;

namespace MAUIControlGallery.Views;

public partial class Notification : ContentPage
{
	public Notification(NotificationViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}