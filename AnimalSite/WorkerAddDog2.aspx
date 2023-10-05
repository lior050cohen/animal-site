<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WorkerAddDog2.aspx.cs" Inherits="AnimalSite.WorkerAddDog2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        window.addEventListener('load', function () {
            var ageRange = document.getElementById("ageRange");
            var ageOut = document.getElementById("ageOut");
            ageRange.onchange = () => {
                ageOut.textContent = ageRange.value + " שנים";
            };
            ageOut.textContent = ageRange.value + " שנים";

            var weightRange = document.getElementById("weightRange");
            var weightOut = document.getElementById("weightOut");
            weightRange.onchange = () => {
                weightOut.textContent = weightRange.value + " פאונד";
            };
            weightOut.textContent = weightRange.value + " פאונד";

            var heightRange = document.getElementById("heightRange");
            var heightOut = document.getElementById("heightOut");
            heightRange.onchange = () => {
                heightOut.textContent = heightRange.value + " אינצ'ים";
            };
            heightOut.textContent = heightRange.value + " אינצ'ים";
        })
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="align-items: center; justify-content: center; display: flex; flex-direction: column">

        <p id="dogAgeTitle">גיל הכלב</p>

        <div>
       <input type="range" min="<%=Session["dog_min_age"] %>" max="<%=Session["dog_max_age"] %>" value="1" class="slider" step="0.5" id="ageRange" name="age">
       <label id="ageOut"></label>
            </div>

        <p id="dogWeightTitle">משקל הכלב</p>
        <div>
       <input type="range" min="<%=Session["dog_min_weight"] %>" max="<%=Session["dog_max_weight"] %>" value="1" step="0.5" class="slider" id="weightRange" name="weight">
       <label id="weightOut"></label>
            </div>

       <p id="dogHeightTitle">גובה הכלב</p>
        <div>
        <input type="range" min="<%=Session["dog_min_height"] %>" max="<%=Session["dog_max_height"] %>" value="1" step="0.5" class="slider" id="heightRange" name="height">
       <label id="heightOut"></label>
        </div>


        <br />
        <br />

        <div>
         <label id="goodWCOut">גרוע עם ילדים</label>
         <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).GoodWithChildren %>" class="slider" id="goodWCRange" name="GoodWithChildren">
         <label id="goodWCOut">טוב עם ילדים</label>
        </div>

        <br />
        <br />

        <div>
           <label id="goodWDOut">גרוע עם כלבים אחרים</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).GoodWithOtherDogs %>" class="slider" id="goodWDRange" name="GoodWithOtherDogs">
           <label id="goodWDOut">טוב עם כלבים אחרים</label>
        </div>
        
        <br />
        <br />

        <div>
           <label id="sheddingOut">לא משאיר שעיר</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).Shedding %>" class="slider" id="sheddingRange" name="Shedding">
           <label id="sheddingOut">משאיר המון שעיר</label>
        </div>

        <br />
        <br />
        
        <div>
           <label id="groomingOut">Less grooming</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).Grooming %>" class="slider" id="groomingRange" name="Grooming">
           <label id="groomingOut">More grooming</label>
        </div>
     
        <br />
        <br />

        <div>
           <label id="droolingOut">Less drooling</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).Drooling %>" class="slider" id="droolingRange" name="Drooling">
           <label id="droolingOut">More drooling</label>
        </div>


        <br />
        <br />
      
        <div>
           <label id="goodWSOut">גרוע עם זרים</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).GoodWithStrangers %>" class="slider" id="goodWSRange" name="GoodWithStrangers">
           <label id="goodWSOut">טוב עם זרים</label>
        </div>

        <br />
        <br />
        
        <div>
           <label id="playfulnessOut">Less playfulness</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).Playfulness %>" class="slider" id="playfulnessRange" name="Playfulness">
           <label id="playfulnessOut">More playfulness</label>
        </div>

        <br />
        <br />
        
        <div>
           <label id="protectivenessOut">Less protectiveness</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).Protectiveness %>" class="slider" id="protectivenessRange" name="Protectiveness">
           <label id="protectivenessOut">More protectiveness</label>
      </div>

      <br />
  <br /><div>
   <label id="trainabilityOut">קשה לאמן</label>
   <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).Trainability %>" class="slider" id="trainabilityRange" name="Trainability">
   <label id="trainabilityOut">קל לאמן</label>
      </div>
      <br />
  <br /><div>
   <label id="energyOut">מאוזן</label>
   <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).Energy %>" class="slider" id="energyRange" name="Energy">
   <label id="energyOut">אנרגתי</label>
      </div>
      <br />
  <br /><div>
   <label>שקט</label>
   <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).Barking %>" class="slider" id="barkingRange" name="Barking">
   <label>רועש</label>
      </div>

   <br />
   <br />
   <asp:Button runat="server" Text="סיום" class="button-5" role="button" OnClick="Continue_Click"  />


    </div>
 </asp:Content>
