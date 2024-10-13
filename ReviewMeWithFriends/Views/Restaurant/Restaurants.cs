namespace ReviewMeWithFriends.Views;

public partial class Restaurants : ContentPage
{

	public Restaurants()
	{
		InitializeComponent();
		var items = new List<string>{"Pivo","Vino"};	
collectionView .ItemsSource = items;
	}
	private async void OnMenuClicked(object sender, EventArgs e)
	{	
		await Navigation.PopAsync();
	}
	private async void OnAddNewRestaurantClicked(object sender, EventArgs e)
	{	
		await Navigation.PushAsync(new NewRestaurant());
	}
	private async void OnRestaurantDetailClicked(object sender, EventArgs e)
	{	
		await Navigation.PushAsync(new RestaurantDetail());
	}
}
