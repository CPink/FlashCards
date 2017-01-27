namespace FlashCards.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategorySeed : DbMigration
    {
        public override void Up()
        {
            Sql(@"insert into Category select '', GetDate(), '0FC6A93A-AD80-4132-8750-0C231972B6F9'");
        }
        
        public override void Down()
        {
        }
    }
}
