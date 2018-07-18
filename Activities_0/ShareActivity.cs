using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Activities_0
{
	[Activity(Label = "ShareActivity")]
	public class ShareActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.ShareActivityLayout);

			var str = Intent.GetStringExtra("myString");
			Log.Debug("===== DEBUG =====", "Data: " + str);
		}

		//===================================================
		// Optional methods to override default android behavior:
		// can save the App state in one of these

		protected override void OnPause()
		{
			base.OnPause();
			Log.Debug("===== DEBUG =====", "PAUSE");

			//SaveState();  // save App state 
		}

		/*void SaveState()    // save App state 
		{
			if(!saved) {
				// save state
			}
		}*/

		protected override void OnDestroy()
		{
			base.OnDestroy();
			Log.Debug("===== DEBUG =====", "DESTROY");

			//SaveState();  // save App state 
		}

		protected override void OnResume()
		{
			base.OnResume();

			// LoadState();

			Log.Debug("===== DEBUG =====", "RESUME");
		}

		public override void OnBackPressed()  
		{
			// commenting this out disable the Android back button:
			// trick to force user to do something (ex: fill out a form)
			// re-enable back btn after user filled out form
			base.OnBackPressed();
			Log.Debug("===== DEBUG =====", "BACK");
		}
	}
}