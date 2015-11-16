using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace chapter2
{
	[Activity (Label = "chapter2", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);  
			SetContentView (Resource.Layout.Main);  var helpButton = FindViewById<ImageButton> (Resource.Id.loginQuestion); 
			helpButton.Click += (sender, e) => {
				var builder = new AlertDialog.Builder (this)
					.SetTitle ("Need Help?")
					.SetMessage ("Here What you Should Do")
					.SetPositiveButton ("Ok", (innerSender, innere) => { });
				var dialog = builder.Create ();
				dialog.Show ();
			}; 

		}

		protected override void OnStart(){
			base.OnStart ();
			TextView aTextView = FindViewById<TextView> (Resource.Id.myTextView);
			aTextView.Text = "Hello !";
		} 

		protected override void OnResume(){
			base.OnResume ();
			// Some init code
		} 

		protected override void OnPause(){
			base.OnPause ();
			// Save data to persistent storage
			// Desallocate big objects
			// Free Hardware like Bluetooth
		} 

		protected override void OnStop(){
			base.OnStop ();
			StopService (new Intent (this, typeof(Service)));
		} 

		protected override void OnRestart(){
			base.OnRestart ();
		} 

		protected override void OnDestroy(){
			base.OnDestroy ();
		}
	}
}