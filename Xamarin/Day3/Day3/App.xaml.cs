namespace Day3;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new Page1())
		{
			BarBackgroundColor = Color.FromHex("#643843"),
			BarTextColor = Color.FromHex("#FFF7D4"),
		};
	}
}
