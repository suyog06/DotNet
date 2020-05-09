using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClasses
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer C1 = new Customer();
            C1.Firstname = "Suyog";
            C1.Lastname = "Shelar";
            string FullName1 = C1.GetFullName();
            Response.Write("Full Name = " + C1.GetFullName() + "</br>");

            PartialCustomer C2 = new PartialCustomer();
            C2.Firstname = "Suyog";
            C2.Lastname = "Shelar";
            string FullName2 = C2.GetFullName();
            Response.Write("Full Name = " + C2.GetFullName());


        }
    }
}