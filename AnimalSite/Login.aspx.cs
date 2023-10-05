using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnimalSite
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["animal_added_message"] = "";

            if (Session["type"] == "Worker")
            {
                Response.Redirect("AnimalView.aspx");
            }

            if (Session["type"] == "Adopter")
            {
                Response.Redirect("RequestAdoption.aspx");
            }
        }

        protected void Worker_Click(object sender, EventArgs e)
        {
            Session["type"] = "Worker";
            Response.Redirect("AnimalView.aspx");
        }

        protected void Adopter_Click(object sender, EventArgs e)
        {
            Session["type"] = "Adopter";
            Response.Redirect("RequestAdoption.aspx");
        }
    }
}