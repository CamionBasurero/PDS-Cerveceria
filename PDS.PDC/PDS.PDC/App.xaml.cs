using PDS.PDC.Services;
using PDS.PDC.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDS.PDC
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Page1();
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
