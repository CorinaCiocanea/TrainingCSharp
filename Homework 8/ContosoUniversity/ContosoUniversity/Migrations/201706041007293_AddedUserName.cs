namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "UserName");
        }
    }
}
