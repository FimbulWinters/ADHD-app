using Syncfusion.Maui.Charts;

namespace ADHD;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		SfCircularChart chart = new SfCircularChart();

    }

    async void GoToActivitiesPageAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("./ActivitiesPage", true);
    }




}

