<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WorkerAddCat.aspx.cs" Inherits="AnimalSite.WorkerAddCat" %>
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
        })
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="align-items: center; justify-content: center; display: flex; flex-direction: column">

        <p id="dogAgeTitle">גיל החתול</p>

        <div>
       <input type="range" min="<%=Session["cat_min_age"] %>" max="<%=Session["cat_max_age"] %>" value="1" class="slider" step="0.5" id="ageRange" name="age">
       <label id="ageOut"></label>
            </div>

        <p id="dogWeightTitle">משקל החתול</p>
        <div>
       <input type="range" min="<%=Session["cat_min_weight"] %>" max="<%=Session["cat_max_weight"] %>" value="1" step="0.5" class="slider" id="weightRange" name="weight">
       <label id="weightOut"></label>
            </div>

        <br />
        <br />

        <div>
         <label id="goodWCOut">גרוע עם ילדים</label>
         <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasCatInfo) Session["cat_info"]).ChildrenFriendly %>" class="slider" id="goodWCRange" name="ChildrenFriendly">
         <label id="goodWCOut">טוב עם ילדים</label>
        </div>

        <br />
        <br />

        <div>
           <label id="goodWDOut">גרוע עם חיות אחרים</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasCatInfo) Session["cat_info"]).OtherPetsFriendly %>" class="slider" id="goodWDRange" name="OtherPetsFriendly">
           <label id="goodWDOut">טוב עם חיות אחרים</label>
        </div>
        
        <br />
        <br />

        <div>
           <label id="sheddingOut">לא משאיר שעיר</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasCatInfo) Session["cat_info"]).Shedding %>" class="slider" id="sheddingRange" name="Shedding">
           <label id="sheddingOut">משאיר המון שעיר</label>
        </div>

        <br />
        <br />
        
        <div>
           <label id="groomingOut">Less grooming</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasCatInfo) Session["cat_info"]).Grooming %>" class="slider" id="groomingRange" name="Grooming">
           <label id="groomingOut">More grooming</label>
        </div>
     
        <br />
        <br />
      
<%--        <div>
           <label id="goodWSOut">גרוע עם זרים</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasDogInfo) Session["dog_info"]).GoodWithStrangers %>" class="slider" id="goodWSRange" name="GoodWithStrangers">
           <label id="goodWSOut">טוב עם זרים</label>
        </div>

        <br />
        <br />--%>
        
        <div>
           <label id="playfulnessOut">Less playfulness</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasCatInfo) Session["cat_info"]).Playfulness %>" class="slider" id="playfulnessRange" name="Playfulness">
           <label id="playfulnessOut">More playfulness</label>
        </div>

        <br />
        <br />
        
        <div>
           <label id="protectivenessOut">Less family friendly</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasCatInfo) Session["cat_info"]).FamilyFriendly %>" class="slider" id="protectivenessRange" name="FamilyFriendly">
           <label id="protectivenessOut">More family friendly</label>
      </div>

      <br />
      <br />

        <div>
           <label id="trainabilityOut">פחות בריא</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasCatInfo) Session["cat_info"]).GeneralHealth %>" class="slider" id="trainabilityRange" name="GeneralHealth">
           <label id="trainabilityOut">יותר בריא</label>
        </div>

         <br />
         <br />

        <div>
           <label id="energyOut">פחות חכם</label>
           <input type="range" min="1" max="5" value="<%=((AnimalSite.ApiNinjasCatInfo) Session["cat_info"]).Intelligence %>" class="slider" id="energyRange" name="Intelligence">
           <label id="energyOut">יותר חכם</label>
        </div>

         <br />
         <br />

   <asp:Button runat="server" Text="סיום" class="button-5" role="button" OnClick="Continue_Click"  />


    </div>
 </asp:Content>
