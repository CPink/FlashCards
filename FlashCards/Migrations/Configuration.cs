using FlashCards.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Migrations
{
    public class Configuration : DbMigrationsConfiguration<FlashCardsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            // not allowed migration, if data loss is possible
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(FlashCardsContext context)
        {
            base.Seed(context);
        }
    }
}
