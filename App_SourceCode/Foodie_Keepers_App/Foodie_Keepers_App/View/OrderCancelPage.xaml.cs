using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Foodie_Keepers_App.View;

namespace Foodie_Keepers_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderCancelPage : ContentPage
    {
        public OrderCancelPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}