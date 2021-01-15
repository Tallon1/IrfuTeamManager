using IrfuTeamManager.Models.IRFU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrfuTeamManager.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Team> getTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team()
                {
                    TeamName = "Ballymena R.F.C.",
                    City = "Antrim",
                    Province = "Ulster",
                },
                new Team()
                {
                    TeamName = "Blackrock College R.F.C.",
                    City = "Dublin",
                    Province = "Leinster",
                },
                new Team()
                {
                    TeamName = "University College Dublin R.F.C.",
                    City = "Dublin",
                    Province = "Leinster",
                },
                new Team()
                {
                    TeamName = "Young Munster",
                    City = "Limerick",
                    Province = "Munster",
                },
            };
            return teams;
        }

        public static List<Player> getPlayers(IrfuContext context)
        {
            List<Player> players = new List<Player>()
            {
                new Player
                {
                    FirstName = "John",
                    LastName = "Doe",
                    TeamName = context.Teams.Find("Ballymena R.F.C.").TeamName,
                    Position = "Loose-Head Prop"
                },
                new Player
                {
                    FirstName = "Adam",
                    LastName = "Row",
                    TeamName = context.Teams.Find("Blackrock College R.F.C.").TeamName,
                    Position = "Tight-Head Prop"
                },
                new Player
                {
                    FirstName = "Joe",
                    LastName = "DiVinto",
                    TeamName = context.Teams.Find("University College Dublin R.F.C.").TeamName,
                    Position = "Hooker"
                },
                new Player
                {
                    FirstName = "John",
                    LastName = "Doe",
                    TeamName = context.Teams.Find("Young Munster").TeamName,
                    Position = "Scrum-Half"
                },
            };
            return players;
        }
    }
}