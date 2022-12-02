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

    }
}
