
namespace Models
{
    public class Team
    {
        public int ID { get; set; }
        public string ? Name { get; set; }
        public string ? City { get; set; }
        public int ? VictoriesAmount { get; set; }
        public int ? DefeatsAmount { get; set; }
        public int ? DrawsAmount { get; set; }
    }

    public class Person
    {
        public int ID { get; set; }
        public string ? FullName { get; set; }
        public string ? Country { get; set; }
        public int ? Number { get; set; }
        public string ? Position { get; set; }
        public int ? TeamID { get; set;}
    }

    public class Playings
    { 
        public int ID { get; set; }
        public int ? FirstTeamID { get; set; }
        public int ? SecondTeamID { get; set; }
        public int ? FTeamGoals { get; set; }
        public int ? STeamGoals { get; set; }
        public int ? PersonID { get; set; }
        public DateOnly ? PlayingDate { get; set; }
    }
}