using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnimalSite
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }
        protected void GoToEventView_Click(object sender, EventArgs e)
        {
            Response.Redirect("EventView.aspx");
        }

        protected void GoToEventCreation_Click(object sender, EventArgs e)
        {
            Response.Redirect("WorkerAddEvent.aspx");
        }

        protected void GoToAnimalView_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnimalView.aspx");
        }

        protected void GoToAnimalCreation_Click(object sender, EventArgs e)
        {
            Response.Redirect("WorkerAddAnimal.aspx");
        }
        protected void GoToRequestAdoption_Click(object sender, EventArgs e)
        {
            Response.Redirect("RequestAdoption.aspx");
        }
    }
}