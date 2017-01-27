using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashCards.DAL
{
    public class FlashCardsInitializer : System.Data.Entity.CreateDatabaseIfNotExists<FlashCardsContext>
    {

        protected override void Seed(FlashCardsContext context)
        {

        }
    }
}