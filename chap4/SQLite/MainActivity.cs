using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SQLite
{
	[Activity (Label = "SQLite", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			string folder =  System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);

			var db = new SQLiteConnection (System. IO. Path. Combine (folder, "myDb. db"));
			
			button.Click  += delegate{

				Person Person = new Person{ Name = FindViewById<EditText> (Resource.Id.editText1).Text };

				int id = db.Insert(Person);

				FindViewById<TextView> (Resource.Id.textView2).Text = "Inserted with success: id "+id;

			};

			Button deleteButton = FindViewById<Button> (Resource.Id.button2);

			deleteButton.Click += delegate {

				var DeletedId = db.Delete<Person> (Convert.ToInt32(FindViewById<EditText> (Resource.Id.editText1).Text));

				FindViewById<TextView> (Resource.Id.textView2).Text = "Id " + Dele   	tedId +  "Deleted With Success";

			};

			db.Commit();
			db.Rollback();


		}
	}
}


