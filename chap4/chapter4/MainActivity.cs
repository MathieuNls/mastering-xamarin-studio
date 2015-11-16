using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace chapter4
{
	[Activity (Label = "chapter4", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			string path = System.Environment.GetFolderPath(System.Environ                               ment.SpecialFolder.Personal);
			string filename = Path.Combine(path, "myfile.txt");

			using (var streamWriter = new StreamWriter(filename, true))
			{
				streamWriter.WriteLine(DateTime.UtcNow);
			}

			using (var streamReader = new StreamReader(filename))
			{
				string content = streamReader.ReadToEnd();
				TextView textView =    FindViewById<TextView> (Resource.Id.textView1);
				Console.WriteLine (content);
			} 

		}
	}
}