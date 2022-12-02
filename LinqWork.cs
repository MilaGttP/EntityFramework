using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DBContext;

namespace EntityFramework
{
    public static class LinqWork
    {
        //----------------- First lab task --------------------------
        public static List<Team> GetTeamsByName(string name)
        {
            List<Team> teams = new List<Team>();
            using (TournamentDBContext db = new TournamentDBContext())
            {
                teams = (from t in db.Teams
                         where t.Name == name
                         select t).ToList<Team>();
            }
            return teams;
        }
        public static List<Team> GetTeamsByCity(string city)
        {
            List<Team> teams = new List<Team>();
            using (TournamentDBContext db = new TournamentDBContext())
            {
                teams = (from t in db.Teams
                         where t.City == city
                         select t).ToList<Team>();
            }
            return teams;
        }
        public static List<Team> GetTeamsByNameAndCity(string name, string city)
        {
            List<Team> teams = new List<Team>();
            using (TournamentDBContext db = new TournamentDBContext())
            {
                teams = (from t in db.Teams
                         where t.Name == name && t.City == city
                         select t).ToList<Team>();
            }
            return teams;
        }

        //----------------- Second lab task --------------------------
        public static Team GetMaxVictoriesAmountTeam()
        {
            Team team = new Team();
            using (TournamentDBContext db = new TournamentDBContext())
            {
                team = (from t in db.Teams
                        where t.VictoriesAmount == db.Teams.Select(t => t.VictoriesAmount).Max()
                        select t).Single<Team>();
            }
            return team;
        }
        public static Team GetMaxDefeatsAmountTeam()
        {
            Team team = new Team();
            using (TournamentDBContext db = new TournamentDBContext())
            {
                team = (from t in db.Teams
                        where t.DefeatsAmount == db.Teams.Select(t => t.DefeatsAmount).Max()
                        select t).Single<Team>();
            }
            return team;
        }
        public static Team GetMaxDrawsAmountTeam()
        {
            Team team = new Team();
            using (TournamentDBContext db = new TournamentDBContext())
            {
                team = (from t in db.Teams
                        where t.DrawsAmount == db.Teams.Select(t => t.DrawsAmount).Max()
                        select t).Single<Team>();
            }
            return team;
        }

        //----------------- Third lab task --------------------------
        public static void AddTeam(Team team)
        {
            using (TournamentDBContext db = new TournamentDBContext())
            {
                Team checkTeam = db.Teams.Where((x) => x.Name == team.Name).FirstOrDefault();
                if (checkTeam == null)
                {
                    db.Teams.Add(team);
                    db.SaveChanges();
                }
            }
        }
        public static void EditTeam()
        {

        }
        public static void DeleteTeam(Team team)
        {
            using (TournamentDBContext db = new TournamentDBContext())
            {
                Team checkTeam = db.Teams.Where((x) => x.Name == team.Name && x.City == team.City).FirstOrDefault();
                if (checkTeam == null) throw new Exception("There isn`t such a team!");
                else
                {
                    Console.Write("Are you sure?"); string answer = Console.ReadLine();
                    if (answer == "Yes" || answer == "yes")
                    {
                        db.Teams.Remove(team);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
