using System;
using System.Xml.Serialization;

namespace Serialization
{
	[XmlRoot("Person")]
	[Serializable]
	public class Person
	{
		#region IXmlSerializable Members
		public string Name { get; set; }
		#endregion

		public Person ()
		{
		}
	}
}

