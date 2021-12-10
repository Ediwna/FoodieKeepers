using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Foodie_Keepers_App.View;

namespace Foodie_Keepers_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            MainPage = new NavigationPage(new EntryPage());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Console.WriteLine("App start");
            Debug.WriteLine("App starts");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Console.WriteLine("App sleep");
            Debug.WriteLine("App sleeps");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Console.WriteLine("App resume");
            Debug.WriteLine("App resumes");
        }
    }
}
