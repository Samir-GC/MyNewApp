using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;



using Xamarin.Forms;

namespace MyNewTest
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MyNewTest.MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("android=00118f07-1329-4ac0-8751-af84bc38b02e;" + "uwp={Your UWP App secret here};" + "ios={Your iOS App secret here}", typeof(Analytics), typeof(Crashes));
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
