using System;

namespace SQLite
{
	public class Person
	{

		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }

		public Person ()
		{
		}
	}
}

