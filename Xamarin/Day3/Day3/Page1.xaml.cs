using System.Collections.ObjectModel;

namespace Day3;

public partial class Page1 : ContentPage
{
	public ObservableCollection<City> cities { get; set; }
	public Page1()
	{
		InitializeComponent();
		 cities = new ObservableCollection<City>()
		{
		    new () { CityName = "New York", Date = "Sep 1, 2022" },
			new () { CityName = "Paris", Date = "Jun 2, 2032" },
			new () { CityName = "Paris", Date = "Jun 2, 2032" },
			new () { CityName = "Tokyo", Date = "Aug 15, 2023" },
			new () { CityName = "Sydney", Date = "Jan 10, 2025" },
			new () { CityName = "London", Date = "Dec 25, 2024" },
		};
		//after create list let it bind on listview item source
		lst.ItemsSource= cities;
	}

	private void lst_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		DisplayAlert("Tapped Item", e.Item.ToString(), "Ok");
	}

	private void lst_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		//lst.SelectedItem = null;
		Navigation.PushModalAsync(new Details(e.SelectedItem as City));
	}

	private async void Delete_Clicked(object sender, EventArgs e)
	{
		var res= await DisplayAlert("Delete", (sender as Button).CommandParameter.ToString(), "Delete","Cancel");

		if (res == true)
		{
			var city = (sender as Button).CommandParameter as City;
			cities.Remove(city);
		}
	}

	private void lst_Refreshing(object sender, EventArgs e)
	{
		cities.Add(new() { CityName = "London", Date = "Dec 25, 2024" });
		cities.Add(new() { CityName = "Alex", Date = "Dec 25, 2024" });
		cities.Add(new() { CityName = "Cairo", Date = "Dec 25, 2024" });
		cities.Add(new() { CityName = "Giza", Date = "Dec 25, 2024" });
		cities.Add(new() { CityName = "Helwan", Date = "Dec 25, 2024" });
		cities.Add(new() { CityName = "Ain Helwan", Date = "Dec 25, 2024" });
		cities.Add(new() { CityName = "Haram", Date = "Dec 25, 2024" });

		lst.IsRefreshing = false;
		lst.EndRefresh();
		lst.ItemsSource=cities;
	}

	private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
	{
	var FilterList=	cities.Where(c => c.CityName.StartsWith(e.NewTextValue));
		lst.ItemsSource = FilterList;
	}
}