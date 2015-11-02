using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Hello_World
{
	[Activity (Label = "Hello_World", MainLauncher = true)]
	public class MainActivity : Activity
	{
	
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			// Get our TextView from the layout resource,
			// and attach an event to it
			TextView view = FindViewById<TextView> (Resource.Id.myTextView);
			
			button.Click += delegate {
				view.Text = "Hello World !";
			};
		}
	}
}