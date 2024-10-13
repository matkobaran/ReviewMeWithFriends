namespace ReviewMeWithFriends.Views;

public partial class NewReview : ContentPage
{
	public NewReview()
	{
		InitializeComponent();
		// new restaurant
		// click choose restaurant and then you have new window:
			// either you can find restaurant in the menu or you can add new restaurant
				// if you choose, it will return to the review and you finish rating
				// or you create a new restaurant and then go back to rating
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
