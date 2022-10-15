namespace ExaminationSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserType", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
