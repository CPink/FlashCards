using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace FlashCards.DAL
{
    public class FlashCardsConfiguration : DbConfiguration
    {
        public FlashCardsConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());

        }
    }
}
