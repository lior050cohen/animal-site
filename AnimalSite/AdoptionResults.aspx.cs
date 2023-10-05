using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnimalSite
{
    public partial class AdoptionResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["dog_adoption_table"] == null || Session["dog_adoption_table"].ToString().Length <= 5)
            {
                Response.Redirect("RequestAdoption.aspx");
                return;
            }
        }
    }
}