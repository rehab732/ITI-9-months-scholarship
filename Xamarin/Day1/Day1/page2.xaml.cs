namespace Day1;

public partial class page2 : ContentPage
{
	public page2()
	{
		InitializeComponent();
	}

	private async void NavigateToPage3(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new page3());
	}
}