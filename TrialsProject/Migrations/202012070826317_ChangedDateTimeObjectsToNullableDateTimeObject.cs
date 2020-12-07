namespace TrialsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDateTimeObjectsToNullableDateTimeObject : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReclamationDs", "DateFabric", c => c.DateTime());
            AlterColumn("dbo.ReclamationDs", "DateFac", c => c.DateTime());
            AlterColumn("dbo.ReclamationHs", "Date", c => c.DateTime());
            AlterColumn("dbo.TraceGPSSites", "DateCreation", c => c.DateTime());
            AlterColumn("dbo.Visites", "StartTime", c => c.DateTime());
            AlterColumn("dbo.Visites", "EndTime", c => c.DateTime());
            AlterColumn("dbo.Visites", "DateModificationEtat", c => c.DateTime());
            AlterColumn("dbo.Visites", "DateVisite", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visites", "DateVisite", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Visites", "DateModificationEtat", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Visites", "EndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Visites", "StartTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TraceGPSSites", "DateCreation", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ReclamationHs", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ReclamationDs", "DateFac", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ReclamationDs", "DateFabric", c => c.DateTime(nullable: false));
        }
    }
}
