namespace ReviewMeWithFriends.Views;

public partial class NewReview : ContentPage
{
	public NewReview()
	{
		InitializeComponent();
		// new restaurant
		// choose restaurant
		// add review 
	}
	private async void OnMenuClicked(object sender, EventArgs e)
	{	
		await Navigation.PopAsync();
	}
	private async void OnSaveClicked(object sender, EventArgs e)
	{	
		await Navigation.PopAsync();
	}
}
