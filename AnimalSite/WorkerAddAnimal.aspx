<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WorkerAddAnimal.aspx.cs" Inherits="AnimalSite.WorkerAddAnimal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>שם החיה</label>
    <input type="text" name="name" />

    <label>סוג החיה</label>
    <%-- To add more animals, add an option and make sure to prefix it with "כלב" or "חתול". Also add it to the switch in the server side. --%>
    <select name="type">
        <option>כלב לברדור</option>
        <option>כלב בולדוג</option>
        <option>כלב מסטיף טיבטי</option>
        <option>כלב פרואני חסר שיער</option>
        <option>כלב בדלינגטון טרייר</option>
        <option>כלב סיני מצויץ</option>
        <option>כלב גריפון</option>
        <option>כלב רועים קטלוני</option>
        <option>כלב בישון פריזה</option>
        <option>כלב פוקס טרייר סמור שיער</option>
        <option>כלב צ'ין יפני</option>
        <option>כלב גולדן רטריבר</option>

        <option>חתול חבשי</option>
        <option>חתול לבקוי אוקראיני</option>
        <option>חתול סקוטיש פולד</option>
        <option>חתול בורמילה</option>
        <option>חתול סנושו</option>
        <option>חתול מאנקס</option>
        <option>חתול טורקיש וואן</option>
        <option>חתול בובטייל יפני</option>
        <option>חתול הסוואנה</option>
        <option>חתול רוסי כחול</option>
        <option>חתול מאו מצרי</option>
        <option>חתול אירופיין שורטהייר</option>
        <option>חתול אמריקן קורל</option>
        <option>חתול טאבי אפור קלאסי</option>
        <option>חתול מיין קון</option>
      
    </select>

    <label>צבע החיה</label>
    <select name="color">
        <option>לבן</option>
        <option>שחור</option>
        <option>אפור</option>
        <option>אפרפר</option>
        <option>פלפל מלח</option>
        <option>אפרסק</option>
        <option>אדום אש</option>
        <option>מנומר</option>
        <option>אדום</option>
        <option>חום</option>
    </select>

    <label>מין החיה</label>
    <select name="gender">
        <option>זכר</option>
        <option>נקבה</option>
    </select>


    <asp:Button runat="server" Text="המשך לשלב הבא" class="button-5" role="button" OnClick="Continue_Click"  />
    <br />
    <label style="color: red"><%=Session["stage1_error"] %></label>
    <label style="color: green"><%=Session["animal_added_message"] %></label>

</asp:Content>
