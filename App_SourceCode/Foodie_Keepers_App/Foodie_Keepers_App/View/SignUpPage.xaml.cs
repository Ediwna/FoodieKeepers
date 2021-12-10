using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Foodie_Keepers_App.ViewModels;

namespace Foodie_Keepers_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        SignUpViewModel signUpViewModel;
        public SignUpPage()
        {
            InitializeComponent();
            signUpViewModel = new SignUpViewModel();
            //set binding    
            BindingContext = signUpViewModel;
        }
        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        private async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new EntryPage());
        }
    }
}