<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AnimalSite.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="justify-content: center; align-items: center; width: 100%; display: flex;">
<asp:Button runat="server" Text="התחבר כעובד" class="button-5" role="button" OnClick="Worker_Click"  />
<asp:Button runat="server" Text="התחבר כמאמץ" class="button-5" role="button" OnClick="Adopter_Click" />
</div>
</asp:Content>
