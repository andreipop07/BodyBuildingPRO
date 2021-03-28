using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BodyBuildingPRO
{
    public partial class App : Application
    {
        public static string FilePath;
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }

        public App(string filePath)
        {
            InitializeComponent();

            MainPage = new Login();

            FilePath = filePath;
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
