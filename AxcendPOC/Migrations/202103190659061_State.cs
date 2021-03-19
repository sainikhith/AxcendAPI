namespace AxcendPOC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class State : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "CSVUpload.State",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "CSVUpload.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Int(),
                        Name = c.String(),
                        City = c.String(),
                        Status = c.Int(),
                        IsActive = c.Boolean(),
                        Enable = c.Boolean(),
                        CreatedOn = c.DateTime(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("CSVUpload.Students");
            DropTable("CSVUpload.State");
        }
    }
}
