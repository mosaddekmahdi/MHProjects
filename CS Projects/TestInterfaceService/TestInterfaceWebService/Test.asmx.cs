using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace TestInterfaceWebService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Test : WebService
    {
        [WebMethod()]
        [return: XmlElement("MyTime", DataType = "time")]
        public DateTime EchoString([XmlElement(DataType = "string")] 
   string strval)
        {
            return DateTime.Now;
        }

        [WebMethod()]
        public BaseVehicle Vehicle(object item)
        {
            if (item.GetType() == typeof(Car))
            {
                Car myItem = item as Car;
                return myItem.GetStuff(item);
            }
            else if (item.GetType() == typeof(Boat))
            {
                Boat myItem = item as Boat;
                return myItem.GetStuff(item);
            }
            return null;
        }

        [WebMethod()]
        public BaseVehicle Get(object item)
        {
            if (item.GetType() == typeof(Car))
            {
                Car myItem = item as Car;
                return myItem.Create(item);
            }
            else if (item.GetType() == typeof(Boat))
            {
                Boat myItem = item as Boat;
                return myItem.Create(item);
            }
            return null;
        }
    }

    [XmlInclude(typeof(Car)), XmlInclude(typeof(Boat))]
    public class BaseVehicle
    {
        public virtual BaseVehicle GetStuff(object item)
        {
            return null;
        }

        public virtual BaseVehicle Create(object item)
        {
            return null;
        }
    }

    public class Car : BaseVehicle
    {
        public string licenseNumber { get; set; }
        #region Vehicle Members

        public override BaseVehicle GetStuff(object item)
        {
            Car myItem = item as Car;
            myItem.licenseNumber = "I am a Car";
            return myItem;
        }

        public override BaseVehicle Create(object item)
        {
            Car myItem = item as Car;
            return myItem;
        }

        #endregion
    }

    public class Boat : BaseVehicle
    {
        public string motor { get; set; }
        #region Vehicle Members

        public override BaseVehicle GetStuff(object item)
        {
            Boat myItem = item as Boat;
            myItem.motor = "I am a Boat";
            return myItem;
        }

        public override BaseVehicle Create(object item)
        {
            Boat myItem = item as Boat;
            return myItem;
        }

        #endregion
    }
}