namespace ReviewMeWithFriends.Views;

public partial class User : ContentPage
{
	public User()
	{
		InitializeComponent();
	}
	private async void OnMenuClicked(object sender, EventArgs e)
	{
		
		await Navigation.PopAsync();

	}
}
