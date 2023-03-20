using ADHD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage(LoginPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        
    }
}