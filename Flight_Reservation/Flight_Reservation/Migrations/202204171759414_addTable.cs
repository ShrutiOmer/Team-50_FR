namespace Flight_Reservation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TbAdminLogin",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        AdName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.TblFlightBook",
                c => new
                    {
                        bid = c.Int(nullable: false, identity: true),
                        From = c.String(nullable: false),
                        To = c.String(nullable: false),
                        DDate = c.DateTime(nullable: false),
                        DTime = c.String(maxLength: 15),
                        Planeid = c.Int(nullable: false),
                        SeatType = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.bid)
                .ForeignKey("dbo.AeroPlaneInfoes", t => t.Planeid, cascadeDelete: true)
                .Index(t => t.Planeid);
            
            CreateTable(
                "dbo.AeroPlaneInfoes",
                c => new
                    {
                        Planeid = c.Int(nullable: false, identity: true),
                        APlaneName = c.String(),
                        SeatingCapacity = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Planeid);
            
            CreateTable(
                "dbo.TblUserAccount",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        CPassword = c.String(),
                        Age = c.Int(nullable: false),
                        Phoneno = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TblFlightBook", "Planeid", "dbo.AeroPlaneInfoes");
            DropIndex("dbo.TblFlightBook", new[] { "Planeid" });
            DropTable("dbo.TblUserAccount");
            DropTable("dbo.AeroPlaneInfoes");
            DropTable("dbo.TblFlightBook");
            DropTable("dbo.TbAdminLogin");
        }
    }
}
