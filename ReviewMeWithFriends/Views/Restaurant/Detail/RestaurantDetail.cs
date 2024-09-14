namespace ReviewMeWithFriends.Views;

public partial class RestaurantDetail : ContentPage
{
	public RestaurantDetail()
	{
		InitializeComponent();
	}
	private async void OnMenuClicked(object sender, EventArgs e)
	{	
		await Navigation.PopAsync();
	}
}
