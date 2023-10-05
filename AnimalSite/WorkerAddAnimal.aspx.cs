using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnimalSite
{
    public partial class WorkerAddAnimal : System.Web.UI.Page
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
            Session["animal_name"] = Request.Form["name"];
            Session["animal_type"] = Request.Form["type"];
            Session["animal_colorname"] = Request.Form["color"];
            Session["animal_ismale"] = Request.Form["gender"].Trim() == "זכר" || Request.Form["gender"].Trim().ToLower() == "male";

            var apiType = "";

            string animalTypeHebrew = Session["animal_type"].ToString().Split(' ').First();
            string hebrewType = string.Join(" ", Session["animal_type"].ToString().Split(' ').Skip(1));

            Session["is_dog"] = animalTypeHebrew == "כלב";
            Session["is_cat"] = animalTypeHebrew == "חתול";

            switch (hebrewType)
            {
                case "חבשי": apiType = "abyssinian"; break;
                case "לבקוי אוקראיני": apiType = "UKRAINIAN LEVKOY"; break;
                case "סקוטיש פולד": apiType = "SCOTTISH FOLD"; break;
                case "בורמילה": apiType = "BURMILLA"; break;
                case "סנושו": apiType = "SNOWSHOE CAT"; break;
                case "מאנקס": apiType = "MANKS"; break;
                case "טורקיש וואן": apiType = "TURKISH VAN"; break;
                case "בובטייל יפני": apiType = "JAPANESE BOBTAIL"; break;
                case "הסוואנה": apiType = "SAVANNAH CAT"; break;
                case "רוסי כחול": apiType = "RUSSIAN BLUE"; break;
                case "מאו מצרי": apiType = "EGYPTIAN MAU"; break;
                case "אירופיין שורטהייר": apiType = "EUROPEAN SHORTHAIR"; break;
                case "אמריקן קורל": apiType = "AMERICAN CURL"; break;
                case "טאבי אפור קלאסי": apiType = "GREY CLASSIC TABY"; break;
                case "מיין קון": apiType = "MAIN COON"; break;

                case "לברדור": apiType = "labrador"; break;
                case "בולדוג": apiType = "bulldog"; break;
                case "מסטיף טיבטי": apiType = "Tibetan Mastiff"; break;
                case "פרואני חסר שיער": apiType = "Peruvian Inca Orchid"; break;
                case "בדלינגטון טרייר": apiType = "Bedlington Terrier"; break;
                case "סיני מצויץ": apiType = "Chinese Crested"; break;
                case "גריפון": apiType = "Griffon Bruxellois"; break;
                case "רועים קטלוני": apiType = "Catalan Sheepdog"; break;
                case "בישון פריזה": apiType = "Bichon Frise"; break;
                case "פוקס טרייר סמור שיער": apiType = "Wire Fox Terrier"; break;
                case "צ'ין יפני": apiType = "Japanese Chin"; break;
                case "גולדן רטריבר": apiType = "golden retriever"; break;
            }

            if ((bool)Session["is_dog"] == true)
            {
                var dogInfo = ApiNinjas.Instance.GetDogInfoAsync(apiType).Result;

                Session["dog_max_age"] = dogInfo.MaxLifeExpectancy;
                Session["dog_min_age"] = 0;

                Session["dog_max_height"] = ((bool)Session["animal_ismale"]) ? dogInfo.MaxHeightMale : dogInfo.MaxHeightFemale;
                Session["dog_min_height"] = ((bool)Session["animal_ismale"]) ? dogInfo.MinHeightMale : dogInfo.MinHeightFemale;

                Session["dog_max_weight"] = ((bool)Session["animal_ismale"]) ? dogInfo.MaxWeightMale : dogInfo.MaxWeightFemale;
                Session["dog_min_weight"] = ((bool)Session["animal_ismale"]) ? dogInfo.MinWeightMale : dogInfo.MinWeightFemale;
                Session["dog_info"] = dogInfo;

                Session["animal_added_message"] = "";

                Response.Redirect("WorkerAddDog2.aspx");
            }

            if ((bool)Session["is_cat"] == true)
            {
                var catInfo = ApiNinjas.Instance.GetCatInfoAsync(apiType).Result;

                Session["cat_max_age"] = catInfo.MaxLifeExpectancy;
                Session["cat_min_age"] = 0;

                Session["cat_max_weight"] = catInfo.MaxWeight;
                Session["cat_min_weight"] = catInfo.MinWeight;

                Session["cat_info"] = catInfo;

                Session["animal_added_message"] = "";

                Response.Redirect("WorkerAddCat.aspx");
            }

        }
    }
}