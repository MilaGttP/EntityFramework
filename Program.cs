
using DBContext;
using Models;

namespace EntityFramework
{
    public class Program
    {
        static void Main()
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
    }
}