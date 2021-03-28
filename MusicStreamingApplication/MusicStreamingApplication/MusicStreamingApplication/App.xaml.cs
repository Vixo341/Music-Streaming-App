using MusicStreamingApplication.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicStreamingApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MusicPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
