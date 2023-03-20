using ADHD.ViewModels;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;


namespace ADHD;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTEyOTgzOEAzMjMwMmUzNDJlMzBCRm9GV1hEVWdBa0p1VUJVRUdhWkdoc2szK2EvN0xEOHdRUkpGZTVqV05zPQ==");
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<Dashboard>();
		builder.Services.AddSingleton<DashboardViewModel>();

		builder.Services.AddSingleton<LoginPage>();
		builder.Services.AddSingleton<LoginPageViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<ActivitiesPage>();
		builder.Services.AddSingleton<ChartViewModel>();
		




		return builder.Build();
	}

	
}
