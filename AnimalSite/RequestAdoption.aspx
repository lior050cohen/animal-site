<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RequestAdoption.aspx.cs" Inherits="AnimalSite.RequestAdoption" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>שם</label>
    <input type="text" name="name" />

    <label>אימייל</label>
    <input type="text" name="email" />


    <label>טלפון</label>
    <input type="text" name="phone" />

    <h2 style="font-size: 30px">Family and Household</h2>

    <label>Number of Household Members</label>
    <select name="members">
        <option value="0">Just me</option>
        <option value="1">Me and a partner</option>
        <option value="2">Small family (3-4 members)</option>
        <option value="3">Large family (5+ members)</option>
        <option value="4">Huge family (8+ members)</option>
    </select>

    <label>Presence of Children</label>
    <select name="children">
        <option value="0">No children</option>
        <option value="1">Yes, under 5 years old</option>
        <option value="2">Yes, 5-12 years old</option>
        <option value="3">Yes, 13-18 years old</option>
        <option value="4">Yes, various ages</option>
    </select>

    <label>Current pets</label>
    <select name="pets">
        <option value="0">No pets</option>
        <option value="1">Cats</option>
        <option value="2">Dogs</option>
        <option value="3">Small mammals (e.g., hamsters, rabbits)</option>
        <option value="4">Other</option>
    </select>

    <h2 style="font-size: 30px">Animal Preferences</h2>

    <label>Size Preference</label>
    <select name="size">
        <option value="0">Small (e.g., Chihuahua, Cat)</option>
        <option value="1">Medium (e.g., Beagle, Bulldog)</option>
        <option value="2">Large (e.g., Labrador, Golden Retriever)</option>
        <option value="3">Any size is welcomed</option>
    </select>

    <label>Activity Level</label>
    <select name="activity">
        <option value="0">Low energy (relaxed and calm)</option>
        <option value="1">Moderate energy (regular walks and play)</option>
        <option value="2">High energy (active and outdoorsy)</option>
        <option value="3">Very high energy (constantly on the go)</option>
    </select>

    <label>Playfulness</label>
    <select name="playfulness">
        <option value="0">Not important</option>
        <option value="1">Somewhat important</option>
        <option value="2">Neutral</option>
        <option value="3">Important</option>
        <option value="4">Very important</option>
    </select>
    
    <label>Allergies</label>
    <select name="allergies">
        <option value="0">No allergies</option>
        <option value="1">Mild allergies</option>
        <option value="2">Moderate allergies</option>
        <option value="3">Severe allergies</option>
    </select>

    <label>Grooming Effort</label>
    <select name="grooming">
        <option value="0">Minimal grooming</option>
        <option value="1">Regular brushing and grooming</option>
        <option value="2">Neutral</option>
        <option value="3">Extensive grooming and maintenance</option>
    </select>

    <label>Training Experience</label>
    <select name="training">
        <option value="0"> No experience</option>
        <option value="1">Limited experience</option>
        <option value="2">Some experience</option>
        <option value="3">Experienced</option>
        <option value="4">Very experienced</option>
    </select>

    <label>Type of Dwelling</label>
    <select name="dwelling">
        <option value="0">Apartment</option>
        <option value="1">Private Home with Yard</option>
    </select>


    <label>Outdoor Space</label>
    <select name="space">
        <option value="0">No</option>
        <option value="1">Small fenced area</option>
        <option value="2">Large fenced yard</option>
    </select>


    <label>Time at Home</label>
    <select name="time">
        <option value="0">Very little time</option>
        <option value="1">Part of the day</option>
        <option value="2">Most of the day</option>
    </select>

    <asp:Button runat="server" Text="המשך לשלב הבא" class="button-5" role="button" OnClick="Continue_Click" />
</asp:Content>
