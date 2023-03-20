using ADHD.ViewModels;

namespace ADHD 
{ 
	public partial class ActivitiesPage : ContentPage
	{
		public ActivitiesPage (ChartViewModel viewModel)
		{
			InitializeComponent();
            BindingContext = viewModel;
            
			
        }

        private void InitializeComponent()
        {
            global::Microsoft.Maui.Controls.Xaml.Extensions.LoadFromXaml(this, typeof(ActivitiesPage));
        }

        async void GoToAddNewActivityAsync(object sender, EventArgs e)
        {
            
            await Shell.Current.GoToAsync("/AddNewActivitiesPage", true);
        }

        

       
    }
}