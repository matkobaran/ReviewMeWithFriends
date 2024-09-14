namespace ReviewMeWithFriends.Views;

public partial class Restaurants : ContentPage
{
	public Restaurants()
	{
		InitializeComponent();
	}
	private async void OnMenuClicked(object sender, EventArgs e)
	{	
		await Navigation.PopAsync();
	}
	private async void OnAddNewRestaurantClicked(object sender, EventArgs e)
	{	
		await Navigation.PushAsync(new NewRestaurant());
	}
}
