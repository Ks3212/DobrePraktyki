using Microsoft.EntityFrameworkCore;
using BibliotekaWeb.Shared;
using BibliotekaWeb.Server.Repositoires;
namespace BibliotekaWeb.Server.Models
{
    public class DataBaseContext: DbContext
    {
        public virtual DbSet<Book> Books { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(BookRepositories.connString);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
        }


    }


}

