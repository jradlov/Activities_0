using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;

namespace Activities_0
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

			Button btn = FindViewById<Button>(Resource.Id.button1);
			btn.Click += delegate {
				var myIntent = new Intent(this, typeof(ShareActivity));

				// if want to pass some data to the Activity:
				myIntent.PutExtra("myString", "I'm a message passed from Main Activity");

				StartActivity(myIntent);
			};
        }
	}
}

