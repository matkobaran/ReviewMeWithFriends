namespace ReviewMeWithFriends.Views;

public partial class Restaurant : ContentPage
{
	public Restaurant()
	{
		InitializeComponent();
	}
	private async void OnMenuClicked(object sender, EventArgs e)
	{	
		await Navigation.PopAsync();
	}
}
