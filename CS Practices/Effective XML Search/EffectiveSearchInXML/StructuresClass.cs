using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EffectiveSearchInXML
{
	enum TableType
	{
		Person = 0,
		Employee = 1,
	}

	static class StructuresClass
	{
		public static List<T> GetResults<T>(String strSearchCriteria = "", String strSearch = "")
		{
			String strTableType = typeof(T).Name;
			dynamic res = null;
			switch (strTableType)
			{
				case "Person":
					{
						res = (from CurrentPerson in XElement.Load("AppData/book.xml").Descendants("person")
							   where CurrentPerson.Element(strSearchCriteria).Value.ToLower().Contains(strSearch.ToLower()) ||
							   (strSearch.Length == 0)
							   select new Person
							   {
								   FirstName = CurrentPerson.Element("first").Value.ToString(),
								   LastName = CurrentPerson.Element("last").Value.ToString(),
								   Age = Convert.ToInt32(CurrentPerson.Element("age").Value),
							   }).ToList<Person>();
					}
					break;
				case "Employee":
					{
						res = (from CurrentPerson in XElement.Load("AppData/Employee-Detail.xml").Descendants("Employee")
							   where CurrentPerson.Element(strSearchCriteria).Value.ToLower().Contains(strSearch.ToLower()) ||
							   (strSearch.Length == 0)
							   select new Employee
							   {
								   ID = CurrentPerson.Element("Emp_Id").Value.ToString(),
								   Name = CurrentPerson.Element("Emp_Name").Value.ToString(),
								   eMail = CurrentPerson.Element("Emp_E-mail").Value.ToString(),
							   }).ToList<Employee>();
					}
					break;
			}

			return res;
		}

		public static List<String> GetCriterias(String strTableType)
		{
			List<String> res = null;
			switch (strTableType)
			{
				case "Person":
					res = (from a in XElement.Load("AppData/book.xml").Descendants("person").ElementAtOrDefault(0).Elements()
						   select a.Name.ToString()).ToList<String>();
					break;
				case "Employee":
					res = (from a in XElement.Load("AppData/Employee-Detail.xml").Descendants("Employee").ElementAtOrDefault(0).Elements()
						   select a.Name.ToString()).ToList<String>();
					break;
			}
			return res;
		}
	}

	[Serializable]
	public class Person
	{
		[XmlAnyElement("first")]
		public String FirstName
		{
			get;
			set;
		}

		[XmlAnyElement("last")]
		public String LastName
		{
			get;
			set;
		}

		[XmlAnyElement("age")]
		public Int32 Age
		{
			get;
			set;
		}
	}

	[Serializable]
	public class Employee
	{

		[XmlAnyElement("Emp_Id")]
		public String ID
		{
			get;
			set;
		}

		[XmlAnyElement("Emp_Name")]
		public String Name
		{
			get;
			set;
		}

		[XmlAnyElement("Emp_E-mail")]
		public String eMail
		{
			get;
			set;
		}
	}

	[Serializable]
	public class Course
	{
		public String footnote
		{
			get;
			set;
		}
		public String sln
		{
			get;
			set;
		}
		public String prefix
		{
			get;
			set;
		}
		public String crs
		{
			get;
			set;
		}
		public String lab
		{
			get;
			set;
		}
		public String sect
		{
			get;
			set;
		}
		public String title
		{
			get;
			set;
		}
		public String credit
		{
			get;
			set;
		}
		public String days
		{
			get;
			set;
		}
		public Times time
		{
			get;
			set;
		}
		public Places place
		{
			get;
			set;
		}
		public String instructor
		{
			get;
			set;
		}
		public String limit
		{
			get;
			set;
		}
		public String enrolled
		{
			get;
			set;
		}
	}

	[Serializable]
	public class Times
	{
		public String start
		{
			get;
			set;
		}
		public String end
		{
			get;
			set;
		}
	}

	[Serializable]
	public class Places
	{
		public String bldg
		{
			get;
			set;
		}
		public Int32 room
		{
			get;
			set;
		}
	}

}
