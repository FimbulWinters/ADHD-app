namespace ADHD;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(Dashboard), typeof(Dashboard));

		Routing.RegisterRoute("ActivitiesPage", typeof(ActivitiesPage));
		Routing.RegisterRoute("AddNewActivitiesPage", typeof(AddNewActivitiesPage));

		
	}

    
}
