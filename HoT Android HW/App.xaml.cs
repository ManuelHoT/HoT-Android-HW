
using HoT_Android_HW.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HoT_Android_HW
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

           
            MainPage = new AboutPage();
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
