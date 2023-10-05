using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnimalSite
{
    public partial class WorkerAddEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] != "Worker")
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Continue_Click(object sender, EventArgs e)
        {
            List<string> missions = new List<string>();

            // Retrieve the mission titles and descriptions from the submitted form
            string[] missionTitles = Request.Form.GetValues("missionTitle[]");
            string[] missionDescriptions = Request.Form.GetValues("missionDescription[]");

            // Loop through the submitted missions
            for (int i = 0; i < missionTitles.Length; i++)
            {
                string title = missionTitles[i];
                string description = missionDescriptions[i];

                missions.Add($"<span style=\"font-size: 20px; font-weight: 700;\">{title}</span>\n{description}\n");
            }

            string query = "INSERT INTO [dbo].[Events] ([Name], [Date], [Location], [Employee], [Missions]) VALUES(" +
                $"N'{Request.Form["name"]}', N'{Request.Form["date"]}', N'{Request.Form["location"]}', N'{Request.Form["employee"]}', N'{string.Join("<br /><br />", missions)}')";

            var res = SQLHelper.DoQuery(query);

            if (res == 1)
            {
                Session["event_added_message"] = "אירוע נוצר בהצלחה";
                Response.Redirect("WorkerAddEvent.aspx");
            }


        }
    }
}