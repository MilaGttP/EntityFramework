using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models;

namespace DBContext
{
    public class TournamentDBContext : DbContext
    {
        public DbSet <Team> Teams { get; set; }
        public TournamentDBContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WIN-DB5IFPI2TC8\SQLEXPRESS;Initial Catalog=Tournaments;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
