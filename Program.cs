
using DBContext;
using Models;

namespace EntityFramework
{
    public class Program
    {
        static void Main()
        {
            //TestIntroductionHW();
            TestLinqLab();
            TestLinqHW();
        }
        static void TestIntroductionHW()
        {
            try
            {
                using (TournamentDBContext db = new TournamentDBContext())
                {
                    Team team1 = new Team { Name = "Barcelona", City = "Barcelona", VictoriesAmount = 143, DefeatsAmount = 13, DrawsAmount = 54 };
                    Team team2 = new Team { Name = "Real", City = "Madrid", VictoriesAmount = 238, DefeatsAmount = 21, DrawsAmount = 43 };

                    db.Teams.Add(team1);
                    db.Teams.Add(team2);
                    db.SaveChanges();

                    foreach (var entity in db.Teams.ToList())
                    {
                        Console.WriteLine($"{entity.ID}\t {entity.Name} {entity.City}");
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        static void TestLinqLab()
        {
            List<Team> teamsByName = new List<Team>();
            teamsByName = LinqWork.GetTeamsByName("Real");
            Console.WriteLine($"Teams count (GetTeamsByName): {teamsByName.Count()}");

            List<Team> teamsByCity = new List<Team>();
            teamsByCity = LinqWork.GetTeamsByName("Madrid");
            Console.WriteLine($"Teams count (GetTeamsByCity): {teamsByCity.Count()}");
        }
        static void TestLinqHW()
        {

        }
    }
}