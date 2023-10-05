using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnimalSite
{
    public partial class AnimalView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] != "Worker")
            {
                Response.Redirect("Login.aspx");
                return;
            }

            DataTable table = SQLHelper.SelectData("SELECT * FROM [dbo].Dogs");
            List<Dog> list = new List<Dog>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var dog = Dog.FromDataTableRow(table, i);
                list.Add(dog);
            }

            Session["dogs_table"] = Dog.GenerateTableFromDogs(list);

            table = SQLHelper.SelectData("SELECT * FROM [dbo].Cats");
            List<Cat> list2 = new List<Cat>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var cat = Cat.FromDataTableRow(table, i);
                list2.Add(cat);
            }

            Session["cats_table"] = Cat.GenerateTableFromCats(list2);
        }
    }
}