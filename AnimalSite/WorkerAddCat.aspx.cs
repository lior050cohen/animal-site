using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnimalSite
{
    public partial class WorkerAddCat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["cat_info"] is ApiNinjasCatInfo))
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Continue_Click(object sender, EventArgs e)
        {
            Session["cat_age"] = Request.Form["age"];
            Session["cat_weight"] = Request.Form["weight"];

            ApiNinjasCatInfo catInfo = (ApiNinjasCatInfo)Session["cat_info"];
            catInfo.ImageLink = "";
            catInfo.FamilyFriendly = int.Parse(Request.Form["FamilyFriendly"]);
            catInfo.GeneralHealth = int.Parse(Request.Form["GeneralHealth"]);
            catInfo.ChildrenFriendly = int.Parse(Request.Form["ChildrenFriendly"]);
            catInfo.Intelligence = int.Parse(Request.Form["Intelligence"]);
            catInfo.OtherPetsFriendly = int.Parse(Request.Form["OtherPetsFriendly"]);

            catInfo.Shedding = int.Parse(Request.Form["Shedding"]);
            catInfo.Grooming = int.Parse(Request.Form["Grooming"]);
            catInfo.Playfulness = int.Parse(Request.Form["Playfulness"]);

            var query = "INSERT INTO [dbo].[Cats] ([Name], [Type], [Origin], [Length], [Image], [Male], [Color], [Age], [Weight], [FamilyFriendly], [Shedding], [GeneralHealth], [ChildrenFriendly], [Grooming], [Intelligence], [OtherPetsFriendly], [Playfulness]) VALUES" +
                $"(N'{Session["animal_name"]}', N'{Session["animal_type"]}', N'{catInfo.Origin}', N'{catInfo.Length}', N'{catInfo.ImageLink}', 0, N'{Session["animal_colorname"]}', {Session["cat_age"]}, {Session["cat_weight"]}, " +
                $"{catInfo.FamilyFriendly}, {catInfo.Shedding}, {catInfo.GeneralHealth}, {catInfo.ChildrenFriendly}, {catInfo.Grooming}, {catInfo.Intelligence}, {catInfo.OtherPetsFriendly}, {catInfo.Playfulness})";
            var res = SQLHelper.DoQuery(query);


            if (res == 1)
            {
                Session["animal_added_message"] = "החתול נוצר בהצלחה";
                Response.Redirect("WorkerAddAnimal.aspx");
            }
        }
    }
}