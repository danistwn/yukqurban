using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace yukqurban.Navigation.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();

            BindingContext = new LoginViewModel();
		}        
	}

    public class LoginViewModel
    {
        public Command RegisterCommand { get; set; }
        public Command ForgotPasswordCommand { get; set; }
        public Command LoginCommand { get; set; }
        public LoginViewModel()
        {
            RegisterCommand = new Command(ActionRegisterCommand);
            ForgotPasswordCommand = new Command(ActionForgotPasswordCommand);
            LoginCommand = new Command(ActionLoginCommand);
        }

        private void ActionLoginCommand(object obj)
        {
            App.Current.MainPage = new Navigation.Main.MainPage();
        }

        private void ActionForgotPasswordCommand(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
        }

        private void ActionRegisterCommand(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }
    }
}