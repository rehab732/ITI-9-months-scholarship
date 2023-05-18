namespace Day3;

public partial class Details : ContentPage
{
	public Details(City Selected)
	{
		InitializeComponent();
		if (Selected != null)
		{
			BindingContext= Selected;
		}

	}
}