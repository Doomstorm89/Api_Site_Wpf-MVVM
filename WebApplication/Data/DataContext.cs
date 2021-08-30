using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class DataContext : DbContext
    {
        public DbSet<News> GetNews { get; set; }
        public List<News.NewsType> NewsTypes => GetNewsTypes().ToList();

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder ) 
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;
                Database=NewsDb;
                Trusted_Connection=True" );
        }

        private IEnumerable<News.NewsType> GetNewsTypes() 
        {
            NewsTypes.Add( News.NewsType.Politics );
            NewsTypes.Add( News.NewsType.Society );
            NewsTypes.Add( News.NewsType.Economics );
            NewsTypes.Add( News.NewsType.Worlds );
            NewsTypes.Add( News.NewsType.Accidents );
            NewsTypes.Add( News.NewsType.Sports );
            NewsTypes.Add( News.NewsType.Sciences );
            NewsTypes.Add( News.NewsType.Tourism );

            return NewsTypes;
        }
    }
}