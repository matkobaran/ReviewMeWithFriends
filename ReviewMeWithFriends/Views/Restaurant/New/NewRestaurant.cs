namespace ReviewMeWithFriends.Views;

public partial class NewRestaurant : ContentPage
{
	public NewRestaurant()
	{
		InitializeComponent();
	}
	private async void OnMenuClicked(object sender, EventArgs e)
	{	
		await Navigation.PopAsync();
	}
	private async void OnSaveNewRestaurantClicked(object sender, EventArgs e)
	{	
		await Navigation.PopAsync();
	}
}
