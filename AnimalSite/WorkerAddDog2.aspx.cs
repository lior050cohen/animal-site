using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnimalSite
{
    public partial class WorkerAddDog2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["dog_info"] is ApiNinjasDogInfo))
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Continue_Click(object sender, EventArgs e)
        {
            Session["dog_age"] = Request.Form["age"];
            Session["dog_weight"] = Request.Form["weight"];
            Session["dog_height"] = Request.Form["height"];

            ApiNinjasDogInfo dogInfo = (ApiNinjasDogInfo)Session["dog_info"];
            dogInfo.GoodWithChildren = int.Parse(Request.Form["GoodWithChildren"]);
            dogInfo.GoodWithOtherDogs = int.Parse(Request.Form["GoodWithOtherDogs"]);
            dogInfo.Shedding = int.Parse(Request.Form["Shedding"]);
            dogInfo.Grooming = int.Parse(Request.Form["Grooming"]);
            dogInfo.Drooling = int.Parse(Request.Form["Drooling"]);
            dogInfo.GoodWithStrangers = int.Parse(Request.Form["GoodWithStrangers"]);
            dogInfo.Playfulness = int.Parse(Request.Form["Playfulness"]);
            dogInfo.Protectiveness = int.Parse(Request.Form["Protectiveness"]);
            dogInfo.Trainability = int.Parse(Request.Form["Trainability"]);
            dogInfo.Energy = int.Parse(Request.Form["Energy"]);
            dogInfo.Barking = int.Parse(Request.Form["Barking"]);

            var query = " INSERT INTO [dbo].[Dogs] ([Name], [Type], [Image], [Male], [Color], [Age], [Height], [Weight], " +
                "[GoodWithChildren], [GoodWithOtherDogs], [Shedding], [Grooming], [Drooling], [GoodWithStrangers], [Playfulness], [Protectiveness], [Trainability], [Energy], [Barking]) VALUES " +
                $"(N'{Session["animal_name"]}', N'{Session["animal_type"]}', N'imagelink', {(((bool)Session["animal_ismale"]) == true ? 1 : 0)}, N'{Session["animal_colorname"]}', {Session["dog_age"]}, {Session["dog_height"]}, {Session["dog_weight"]}, " +
                $"{dogInfo.GoodWithChildren}, {dogInfo.GoodWithOtherDogs}, {dogInfo.Shedding}, {dogInfo.Grooming}, {dogInfo.Drooling}, {dogInfo.GoodWithStrangers}, {dogInfo.Playfulness}, {dogInfo.Protectiveness}, {dogInfo.Trainability}, {dogInfo.Energy}, {dogInfo.Barking})";
            var res = SQLHelper.DoQuery(query);

            if (res == 1)
            {
                Session["animal_added_message"] = "הכלב נוצר בהצלחה";
                Response.Redirect("WorkerAddAnimal.aspx");
            }
        }
    }
}