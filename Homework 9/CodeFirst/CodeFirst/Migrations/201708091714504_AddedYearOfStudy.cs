namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedYearOfStudy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "YearOfStudy", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "YearOfStudy");
        }
    }
}
