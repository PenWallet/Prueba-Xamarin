using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Weather.Services;
using Xamarin_Weather.ViewModels;
using Xamarin_Weather.Views;

namespace Xamarin_Weather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
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
