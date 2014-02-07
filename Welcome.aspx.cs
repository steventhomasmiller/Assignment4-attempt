using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["PersonKey"] != null)
        {
            int pk = (int)Session["PersonKey"];
            ManageVehicle mv = new ManageVehicle();
            DataTable table = mv.GetVehicle(pk);
            foreach (DataRow row in table.Rows)
            {
                lblHello.Text = "Welcome back, " + row["FirstName"].ToString() + " " + row["LastName"].ToString() + "!!!!!";
            }
            gvVehicle.DataSource = table;
            gvVehicle.DataBind();
        }
        else 
        {
            Response.Redirect("Default.aspx");
        }
       
    }
}