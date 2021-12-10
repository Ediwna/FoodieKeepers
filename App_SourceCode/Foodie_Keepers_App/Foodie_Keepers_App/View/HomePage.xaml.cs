using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foodie_Keepers_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BhcChickenRestaurantPage());

        }
        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HaidilaoRetsaurantPage());

        }
        private async void Button_Clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BurgerKingRestaurantPage());

        }
        private async void Button_Clicked4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CoteJardinRestaurantPage());
        }
        private async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}