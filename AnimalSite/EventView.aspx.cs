using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnimalSite
{
    public partial class EventView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] != "Worker")
            {
                Response.Redirect("Login.aspx");
                return;
            }

            DataTable table = SQLHelper.SelectData("SELECT * FROM [dbo].Events");
            List<Event> list = new List<Event>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var @event = Event.FromDataTableRow(table, i);
                list.Add(@event);
            }

            Session["events_table"] = Event.GenerateTableFromEvents(list);
        }
    }
}