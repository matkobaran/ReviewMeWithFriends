namespace ReviewMeWithFriends.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}
	private async void OnReviewsClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Menu());
	}
	private async void OnRestaurantClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Restaurant());
	}
	private async void OnNewReviewClicked(object sender, EventArgs e)
	{	
		await Navigation.PushAsync(new NewReview());
	}
	private async void OnUserClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new User());
	}
}
