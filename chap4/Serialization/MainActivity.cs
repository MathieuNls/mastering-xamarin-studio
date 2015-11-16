using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
	[Activity (Label = "Serialization", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			using (var ms = new MemoryStream()) {

				XmlSerializer mySerializer = new XmlSerializer (typeof(Person));

				var Person = new Person ();
				Person.Name = "Mathieu";

				mySerializer.Serialize (ms, Person);
			}

			using (var ms = new MemoryStream()) {

				XmlSerializer mySerializer = new XmlSerializer (typeof(SomeData));

				var someData = new Person  ();
				someData.Name = "Mathieu";

				mySerializer.Serialize (ms, someData);

				ms.Position = 0;
				Person deserialize = 
					(Person)mySerializer.Deserialize (ms);

				Button button = FindViewById<Button> (Resource.Id.myButton);

				button.Text = deserialize.Name;   
			}
		}
	}
}