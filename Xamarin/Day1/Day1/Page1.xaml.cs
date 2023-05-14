
namespace Day1;
public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}
	void selectnum(object sender,EventArgs e)
	{
		Button button = (Button)sender;
		
		if (button != null)
		{
			//string number = button.CommandParameter.ToString();
			string txt = button.Text;
			result.Text += txt;
		}
	}
	private async void NavigateToPage2(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new page2());
	}

	void clear(object sender,EventArgs e)
	{
		Button button = (Button)sender;

		if (button != null)
		{
			result.Text ="";
		}
	}
}