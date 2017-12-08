using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var svc = new localhost.Test();
            var item = new localhost.Car() { licenseNumber = "12345" };
            var stuff = svc.Get(item);
            lblStuff.Text = (stuff as localhost.Car).licenseNumber;
            var item2 = new localhost.Boat() { motor = "V8" };
            Label1.Text = (svc.Get(item2) as localhost.Boat).motor;
        }
    }
}