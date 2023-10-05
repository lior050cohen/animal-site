<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdoptionResults.aspx.cs" Inherits="AnimalSite.AdoptionResults" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>תוצאות השאלון</label>
    <br />

    <label>כלבים</label>
    <%=Session["dog_adoption_table"] %>
    <br />
    <br />
    <label>חתולים</label>
    <%=Session["cat_adoption_table"] %>


</asp:Content>
