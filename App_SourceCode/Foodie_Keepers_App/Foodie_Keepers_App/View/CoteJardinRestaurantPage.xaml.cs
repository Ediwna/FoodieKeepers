using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foodie_Keepers_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoteJardinRestaurantPage : ContentPage
    {
        public CoteJardinRestaurantPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderSuccessPage());
        }
        private async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new EntryPage());
        }
    }
}