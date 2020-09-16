using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello14
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "Shapes_Experimental" });
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
