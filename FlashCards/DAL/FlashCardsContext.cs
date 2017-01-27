using System.Data.Entity;
using FlashCards.Data.Models;
using FlashCards.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FlashCards.DAL
{
    public class FlashCardsContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<CardDeck> CardDecks { get; set; }

        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}
