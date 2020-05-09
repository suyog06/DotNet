using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration; 

namespace Indexers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // for video 64
            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(CS))
            //{
            //    SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        Response.Write("Id = " + rdr[0].ToString() + " ");
            //        Response.Write("Name = " + rdr["Name"].ToString());
            //        Response.Write("<br/>");
            //    }
            //}





            //for video 65

            Company company = new Company();
            //Response.Write("Name of Employee with Id = 2: " + company[2]);
            //Response.Write("<br/>");
            //Response.Write("Name of Employee with Id = 5: " + company[5]);
            //Response.Write("<br/>");
            //Response.Write("Name of Employee with Id = 8: " + company[8]);

            //Response.Write("<br/>");
            //Response.Write("<br/>");

            //Response.Write("Changing names of employees with Id = 2,5,8");
            //Response.Write("<br/>");
            //company[2] = "Employee 2 Name Changed";
            //company[5] = "Employee 5 Name Changed";
            //company[8] = "Employee 8 Name Changed";

            //Response.Write("Name of Employee with Id = 2: " + company[2]);
            //Response.Write("<br/>");
            //Response.Write("Name of Employee with Id = 5: " + company[5]);
            //Response.Write("<br/>");
            //Response.Write("Name of Employee with Id = 8: " + company[8]);






            // for video 66
            Response.Write("Before changing the Gender of all male employees to Female");
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Male:" + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Female:" + company["Female"]);
            Response.Write("<br/>");
            Response.Write("<br/>");

            company["Male"] = "Female";

            Response.Write("After changing the Gender of all male employees to Female");
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Male:" + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Female:" + company["Female"]);


        }
    }
}