using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace AnimalSite
{
    public partial class RequestAdoption : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Continue_Click(object sender, EventArgs e)
        {
            double getVarMax(string name, int max)
            {
                return double.Parse(Request.Form[name]) / max;
            }

            /// Returns number from 0-4 (or less)
            int getVar(string name)
            {
                return int.Parse(Request.Form[name]);
            }

            double closer(double a, double b)
            {
                return 1 - Math.Abs(a - b);
            }

            DataTable table = SQLHelper.SelectData("SELECT * FROM [dbo].Dogs");
            List<(Dog, double)> dogs = new List<(Dog, double)>();
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var dog = Dog.FromDataTableRow(table, i);
                double score = 0.0;

                /// If the number of family members in the family's preference matches or is greater than the animal's required family size.

                /// If the presence of children in the family's preference matches the animal's compatibility with children.
                score += getVar("children") != 0 ? dog.GoodWithChildren / 5.0 : 0;

                /// If the type and number of current pets in the family's preference match the animal's compatibility with other pets.
                if (dog.GoodWithOtherDogs <= 2 && getVar("pets") != 0) score--;
                if (dog.GoodWithOtherDogs > 3 && getVar("pets") != 0) score++;

                /// If the animal's size falls within the range specified in the family's size preference.
                score += closer(getVar("size"), (dog.Weight - 20)/80*3);

                /// If the animal's activity level matches or is compatible with the family's preferred activity level.
                score += closer(getVar("activity")/3, (dog.Energy-1)/4);

                ///If the animal's playfulness matches or is compatible with the family's preferred playfulness level.
                score += closer(getVar("playfulness")/4, (dog.Playfulness-1)/4);

                /// If the animal's allergenicity matches or is compatible with the family's allergy preferences.

                ///If the animal's grooming effort matches or is compatible with the family's grooming effort preference.
                score += closer(getVar("grooming")/3, (dog.Grooming-1)/4);

                /// If the animal's required training experience level matches or is lower than the family's training experience.
                score += closer(getVar("training")/4, (dog.Trainability-1)/4);

                /// If the animal's housing type requirement matches or is compatible with the family's housing type preference.
                if (getVar("dwelling") == 0) score -= (dog.Energy-1)/4*2;
                if (getVar("dwelling") == 1) score += (dog.Energy-1)/4*2;

                /// If the family has a fenced outdoor area and the animal's outdoor space requirement matches or is compatible.

                /// If the family's usual time spent at home matches or is compatible with the animal's needs.

                dogs.Add((dog, score));
            }

            dogs = dogs.Where(dog => dog.Item2 > 0).OrderBy(dog => dog.Item2).ToList();

            Session["dog_adoption_table"] = Dog.GenerateTableFromDogs(dogs.Select((a) => a.Item1).ToList(), dogs.Select((a) => a.Item2).ToList());

            table = SQLHelper.SelectData("SELECT * FROM [dbo].Cats");
            List<(Cat, double)> cats = new List<(Cat, double)>();
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var cat = Cat.FromDataTableRow(table, i);
                double score = 0.0;

                /// If the number of family members in the family's preference matches or is greater than the animal's required family size.

                /// If the presence of children in the family's preference matches the animal's compatibility with children.
                score += getVar("children") != 0 ? cat.ChildrenFriendly / 5.0 : 0;

                /// If the type and number of current pets in the family's preference match the animal's compatibility with other pets.
                if (cat.OtherPetsFriendly <= 2 && getVar("pets") != 0) score--;
                if (cat.OtherPetsFriendly > 3 && getVar("pets") != 0) score++;

                /// If the animal's size falls within the range specified in the family's size preference.
                score += closer(getVar("size"), (cat.Weight - 20)/80*3);

                /// If the animal's activity level matches or is compatible with the family's preferred activity level.
                score += closer(getVar("activity")/3, (1-1)/4);

                ///If the animal's playfulness matches or is compatible with the family's preferred playfulness level.
                score += closer(getVar("playfulness")/4, (cat.Playfulness-1)/4);

                /// If the animal's allergenicity matches or is compatible with the family's allergy preferences.

                ///If the animal's grooming effort matches or is compatible with the family's grooming effort preference.
                score += closer(getVar("grooming")/3, (cat.Grooming-1)/4);

                /// If the animal's required training experience level matches or is lower than the family's training experience.
                score += closer(getVar("training")/4, (cat.Intelligence-1)/4);

                /// If the animal's housing type requirement matches or is compatible with the family's housing type preference.
                if (getVar("dwelling") == 0) score -= (1-1)/4*2;
                if (getVar("dwelling") == 1) score += (1-1)/4*2;

                /// If the family has a fenced outdoor area and the animal's outdoor space requirement matches or is compatible.

                /// If the family's usual time spent at home matches or is compatible with the animal's needs.

                cats.Add((cat, score));
            }

            cats = cats.Where(cat => cat.Item2 > 0).OrderBy(cat => cat.Item2).ToList();

            Session["cat_adoption_table"] = Cat.GenerateTableFromCats(cats.Select((a) => a.Item1).ToList(), cats.Select((a) => a.Item2).ToList());

            Response.Redirect("AdoptionResults.aspx");
        }
    }
}