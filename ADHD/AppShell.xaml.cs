namespace ADHD;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("ActivitiesPage", typeof(ActivitiesPage));
		Routing.RegisterRoute("AddNewActivitiesPage", typeof(AddNewActivitiesPage));

		
	}
}
