<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AnimalView.aspx.cs" Inherits="AnimalSite.AnimalView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>כלבים</label>
    <%=Session["dogs_table"] %>
    <br />
    <br />
    <label>חתולים</label>
    <%=Session["cats_table"] %>
</asp:Content>
