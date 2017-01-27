namespace FlashCards.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AspNetUsersSeed : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                insert into AspNetUsers
                select '0FC6A93A-AD80-4132-8750-0C231972B6F9', 'Chance', null, 'Pinkerton', 'chance@chance.com', 1, 'AAvBO3UeYV9llz1Reua9p6XssFqGiy50mKsiFAoeqZHz9joqN7LzzLWZ3nOyw8aalw==', 'd82f3e98-3886-4ac3-a921-a1832b734d56', null, 0, 0, null, 0, 0, 'chance@chance.com'
                ");
        }
        
        public override void Down()
        {
        }
    }
}
