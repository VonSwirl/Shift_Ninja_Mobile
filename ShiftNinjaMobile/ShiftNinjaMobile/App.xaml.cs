using System;

using ShiftNinjaMobile.Views;
using Xamarin.Forms;

namespace ShiftNinjaMobile
{
	public partial class App : Application
	{

        public static bool IsWindows10 { get; set; }
        public App()
        {
            MainPage = new RootPage();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
