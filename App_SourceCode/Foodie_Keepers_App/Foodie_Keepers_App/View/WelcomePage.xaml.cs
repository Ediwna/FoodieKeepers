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
    public partial class WelcomePage : ContentPage
    {
        WelcomeViewModel welcomeViewModel;
        public WelcomePage(string email)
        {
            InitializeComponent();
            welcomeViewModel = new WelcomeViewModel(email);
            BindingContext = welcomeViewModel;
        }
        private async void orderbtnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
        private async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new EntryPage());
        }
    }
}