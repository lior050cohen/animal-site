using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AnimalSite
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string Employee { get; set; }
        public string Missions { get; set; }

        public static Event FromDataTableRow(DataTable table, int row)
        {
            var @event = new Event();
            for (int j = 0; j < table.Columns.Count; j++)
            {
                switch (table.Columns[j].ColumnName)
                {
                    case "Name":
                        @event.Name = table.Rows[row][j].ToString(); break;
                    case "Location":
                        @event.Location = table.Rows[row][j].ToString(); break;
                    case "Date":
                        @event.Date = table.Rows[row][j].ToString(); break;
                    case "Employee":
                        @event.Employee = table.Rows[row][j].ToString(); break;
                    case "Missions":
                        @event.Missions = table.Rows[row][j].ToString(); break;
                }
            }
            return @event;
        }

        public static string GenerateTableFromEvents(List<Event> events)
        {
            string html = "<table id=\"pets-table\"><tr>";

            html += "<th>שם</th>";
            html += "<th>תאריך</th>";
            html += "<th>מיקום</th>";
            html += "<th>מפיק</th>";
            html += "<th>משימות</th>";
            html += "</tr>";

            for (int i = 0; i < events.Count; i++)
            {
                html += "<tr>";
                var @event = events[i];

                html += $"<td>{@event.Name}</td>";
                html += $"<td>{@event.Date}</td>";
                html += $"<td>{@event.Location}</td>";
                html += $"<td>{@event.Employee}</td>";
                html += $"<td style=\"line-height: 12px;\">{@event.Missions.Replace("\n", "<br /><br />")}</td>";

                html += "</tr>";
            }

            html += "</table>";
            return html;
        }
    }
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Origin { get; set; }
        public string Length { get; set; }
        public string Image { get; set; }
        public bool Male { get; set; }
        public string Color { get; set; }
        public double Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int FamilyFriendly { get; set; }
        public int GeneralHealth { get; set; }
        public int Shedding { get; set; }
        public int Grooming { get; set; }
        public int ChildrenFriendly { get; set; }
        public int Intelligence { get; set; }
        public int OtherPetsFriendly { get; set; }
        public int Playfulness { get; set; }

        public static Cat FromDataTableRow(DataTable table, int row)
        {
            var cat = new Cat();
            for (int j = 0; j < table.Columns.Count; j++)
            {
                switch (table.Columns[j].ColumnName)
                {
                    case "Name":
                        cat.Name = table.Rows[row][j].ToString(); break;
                    case "Type":
                        cat.Type = table.Rows[row][j].ToString(); break;
                    case "Image":
                        cat.Image = table.Rows[row][j].ToString(); break;
                    case "Male":
                        cat.Male = (bool)table.Rows[row][j]; break;
                    case "Color":
                        cat.Color = table.Rows[row][j].ToString(); break;
                    case "Age":
                        cat.Age = (double)table.Rows[row][j]; break;
                    case "Height":
                        cat.Height = (double)table.Rows[row][j]; break;
                    case "Weight":
                        cat.Weight = (double)table.Rows[row][j]; break;
                    case "FamilyFriendly":
                        cat.FamilyFriendly = (int)table.Rows[row][j]; break;
                    case "GeneralHealth":
                        cat.GeneralHealth = (int)table.Rows[row][j]; break;
                    case "Shedding":
                        cat.Shedding = (int)table.Rows[row][j]; break;
                    case "ChildrenFriendly":
                        cat.ChildrenFriendly = (int)table.Rows[row][j]; break;
                    case "Playfulness":
                        cat.Playfulness = (int)table.Rows[row][j]; break;
                    case "Grooming":
                        cat.Grooming = (int)table.Rows[row][j]; break;
                    case "Intelligence":
                        cat.Intelligence = (int)table.Rows[row][j]; break;
                    case "OtherPetsFriendly":
                        cat.OtherPetsFriendly = (int)table.Rows[row][j]; break;
                    case "Origin":
                        cat.Origin = table.Rows[row][j].ToString(); break;
                    case "Length":
                        cat.Length = table.Rows[row][j].ToString(); break;
                }
            }
            return cat;
        }

        public static string GenerateTableFromCats(List<Cat> cats, List<double> scores = null)
        {
            string html = "<table id=\"pets-table\"><tr>";

            html += "<th>שם</th>";
            html += "<th>זן</th>";
            html += "<th>מקור</th>";
            html += "<th>אורך</th>";
            html += "<th>מין</th>";
            html += "<th>צבע</th>";
            html += "<th>גיל</th>";
            html += "<th>גובה</th>";
            html += "<th>משקל</th>";
            if (scores != null) html += "<th>התאמה</th>";
            if (scores != null) html += "<th></th>";
            html += "</tr>";

            for (int i = 0; i < cats.Count; i++)
            {
                html += "<tr>";
                var cat = cats[i];

                html += $"<td>{cat.Name}</td>";
                html += $"<td>{cat.Type}</td>";
                html += $"<td>{cat.Origin}</td>";
                html += $"<td>{cat.Length}</td>";
                html += $"<td>{(cat.Male ? "זכר" : "נקבה")}</td>";
                html += $"<td>{cat.Color}</td>";
                html += $"<td>{cat.Age} שנים</td>";
                html += $"<td>{cat.Height} אינצ'ים</td>";
                html += $"<td>{cat.Weight} פאונד</td>";
                if (scores != null) html += $"<td>{scores[i]}</td>";
                if (scores != null) html += $"<td><a href=\"#\">שלח בקשה</a></td>";

                html += "</tr>";
            }

            html += "</table>";
            return html;
        }
    }

    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public bool Male { get; set; }
        public string Color { get; set; }
        public double Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int GoodWithChildren { get; set; }
        public int GoodWithOtherDogs { get; set; }
        public int Shedding { get; set; }
        public int Grooming { get; set; }
        public int Drooling { get; set; }
        public int GoodWithStrangers { get; set; }
        public int Playfulness { get; set; }
        public int Protectiveness { get; set; }
        public int Trainability { get; set; }
        public int Energy { get; set; }
        public int Barking { get; set; }

        public static Dog FromDataTableRow(DataTable table, int row)
        {
            var dog = new Dog();
            for (int j = 0; j < table.Columns.Count; j++)
            {
                switch (table.Columns[j].ColumnName)
                {
                    case "Name":
                        dog.Name = table.Rows[row][j].ToString(); break;
                    case "Type":
                        dog.Type = table.Rows[row][j].ToString(); break;
                    case "Image":
                        dog.Image = table.Rows[row][j].ToString(); break;
                    case "Male":
                        dog.Male = (bool)table.Rows[row][j]; break;
                    case "Color":
                        dog.Color = table.Rows[row][j].ToString(); break;
                    case "Age":
                        dog.Age = (double)table.Rows[row][j]; break;
                    case "Height":
                        dog.Height = (double)table.Rows[row][j]; break;
                    case "Weight":
                        dog.Weight = (double)table.Rows[row][j]; break;
                    case "GoodWithChildren":
                        dog.GoodWithChildren = (int)table.Rows[row][j]; break;
                    case "GoodWithOtherDogs":
                        dog.GoodWithOtherDogs = (int)table.Rows[row][j]; break;
                    case "Shedding":
                        dog.Shedding = (int)table.Rows[row][j]; break;
                    case "Grooming":
                        dog.Grooming = (int)table.Rows[row][j]; break;
                    case "Drooling":
                        dog.Drooling = (int)table.Rows[row][j]; break;
                    case "GoodWithStrangers":
                        dog.GoodWithStrangers = (int)table.Rows[row][j]; break;
                    case "Playfulness":
                        dog.Playfulness = (int)table.Rows[row][j]; break;
                    case "Protectiveness":
                        dog.Protectiveness = (int)table.Rows[row][j]; break;
                    case "Trainability":
                        dog.Trainability = (int)table.Rows[row][j]; break;
                    case "Energy":
                        dog.Energy = (int)table.Rows[row][j]; break;
                    case "Barking":
                        dog.Barking = (int)table.Rows[row][j]; break;
                }
            }
            return dog;
        }

        public static string GenerateTableFromDogs(List<Dog> dogs, List<double> scores = null)
        {
            string html = "<table id=\"pets-table\"><tr>";

            html += "<th>שם</th>";
            html += "<th>זן</th>";
            html += "<th>מין</th>";
            html += "<th>צבע</th>";
            html += "<th>גיל</th>";
            html += "<th>גובה</th>";
            html += "<th>משקל</th>";
            if (scores != null) html += "<th>התאמה</th>";
            if (scores != null) html += "<th></th>";
            html += "</tr>";

            for (int i = 0; i < dogs.Count; i++)
            {
                html += "<tr>";
                var dog = dogs[i];

                html += $"<td>{dog.Name}</td>";
                html += $"<td>{dog.Type}</td>";
                html += $"<td>{(dog.Male ? "זכר" : "נקבה")}</td>";
                html += $"<td>{dog.Color}</td>";
                html += $"<td>{dog.Age} שנים</td>";
                html += $"<td>{dog.Height} אינצ'ים</td>";
                html += $"<td>{dog.Weight} פאונד</td>";
                if (scores != null) html += $"<td>{scores[i]}</td>";
                if (scores != null) html += $"<td><a href=\"#\">שלח בקשה</a></td>";

                html += "</tr>";
            }

            html += "</table>";
            return html;
        }
    }
}