<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WorkerAddEvent.aspx.cs" Inherits="AnimalSite.WorkerAddEvent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        window.addEventListener('load', function () {
            function addMission() {
                const missionsContainer = document.getElementById('missionsContainer');

                const missionDiv = document.createElement('div');
                missionDiv.innerHTML = `
                <br/>
                <br/>
                <div>
                    <div style="display: flex; flex-direction: row; align-items: flex-start; justify-content: center;">
                        <label style="min-width: 100px;">כותרת משימה</label>
                        <input type="text" name="missionTitle[]" required>
                    </div>
                    <div style="display: flex; flex-direction: row; align-items: flex-start;">
                        <label style="min-width: 100px;">תיאור משימה</label>
                        <textarea name="missionDescription[]" required></textarea>
                    </div>
                </div>
                <button type="button" style="background-color: #e13d3d; " class="button-5 removeMission">מחק אירוע</button>
            `;

                missionsContainer.appendChild(missionDiv);

                // Add an event listener to the "Remove Mission" button
                const removeMissionButton = missionDiv.querySelector('.removeMission');
                removeMissionButton.addEventListener('click', () => {
                    missionsContainer.removeChild(missionDiv);
                });
            }

            // Add event listener to the "Add Mission" button
            const addMissionButton = document.getElementById('addMission');
            addMissionButton.addEventListener('click', addMission);
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>שם האירוע</label>
    <br />
    <input type="text" name="name" />

    <br />
    <br />

    <label>תאריך האירוע</label>
    <br />
    <input type="date" name="date" />

    <br />
    <br />

    <label>מיקום האירוע</label>
    <br />
    <input type="text" name="location" />

    <br />
    <br />

    <label>מפיק האירוע</label>
    <br />
    <select name="employee">
        <option>אור מימון</option>
        <option>ליאת בורדו</option>
        <option>מור לוי</option>
        <option>שפרה חזקיה</option>
        <option>אופק יקים</option>
        <option>אודי פארן</option>
    </select>

    <div id="missionsContainer">
        <!-- Mission input fields will be added here dynamically -->
    </div>

    <br />
    <br />
    <button type="button" class="button-5" style="background-color: #42a77c; " id="addMission">הוסף משימה</button>
    <br />
    <br />
    <br />

<%--    <label>משימות לביצוע</label>
    <input type="number" name="tasks" />--%>

    <asp:Button runat="server" Text="הוסף אירוע" class="button-5" role="button" OnClick="Continue_Click"  />
    <br />
    <label style="color: green"><%=Session["event_added_message"] %></label>

</asp:Content>
