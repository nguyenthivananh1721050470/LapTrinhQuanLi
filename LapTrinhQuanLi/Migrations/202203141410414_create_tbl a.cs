namespace LapTrinhQuanLi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_tbla : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HeDaotaos",
                c => new
                    {
                        MaHeDT = c.String(nullable: false, maxLength: 128),
                        TenHeDT = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaHeDT);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        MaMonHoc = c.String(nullable: false, maxLength: 128),
                        TenMonHoc = c.String(nullable: false),
                        SoTin = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaMonHoc);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MonHocs");
            DropTable("dbo.HeDaotaos");
        }
    }
}
