namespace TrialsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticleParSites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QteMin = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Prix = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SiteId = c.Int(nullable: false),
                        ArticleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Libelle = c.String(),
                        CodeEAN = c.String(),
                        QteDansRayon = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Prix = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategorieSiteClients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Libelle = c.String(),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        RaisonSociale = c.String(),
                        MatriculeFiscale = c.String(),
                        Adresse = c.String(),
                        Latitude = c.Double(),
                        Longitude = c.Double(),
                        IsDeleted = c.Boolean(nullable: false),
                        Tel = c.String(),
                        Gouvernorat = c.String(),
                        FamilleId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientsMarchandisers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UtilisateurId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ComputerDocuments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Dernier = c.Int(nullable: false),
                        Format = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FamilleClients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Designation = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        Stat = c.Int(nullable: false),
                        Stat2 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LigneRapportVisites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VisiteId = c.Int(nullable: false),
                        ArticleId = c.Int(nullable: false),
                        QteMin = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QteActuel = c.Decimal(precision: 18, scale: 2),
                        Note = c.String(),
                        Photo = c.Binary(),
                        QteVendu = c.Decimal(precision: 18, scale: 2),
                        QteReserve = c.Decimal(precision: 18, scale: 2),
                        Prix = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        DateValidation = c.DateTime(),
                        DateCreation = c.DateTime(nullable: false),
                        DateDernierModification = c.DateTime(nullable: false),
                        IdMarchadiser = c.Int(nullable: false),
                        UserIdModif = c.Int(nullable: false),
                        UserIdCreation = c.Int(nullable: false),
                        UserIdValidation = c.Int(),
                        Note = c.String(),
                        IsValidated = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReclamationDs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Reclamation = c.Guid(nullable: false),
                        CodeProduit = c.String(),
                        Désignation = c.String(),
                        Qt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NLot = c.String(),
                        DateFabric = c.DateTime(nullable: false),
                        NFact = c.String(),
                        DateFac = c.DateTime(nullable: false),
                        Observations = c.String(),
                        DécisionRetour = c.Boolean(nullable: false),
                        Ordre = c.Int(nullable: false),
                        ImageName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReclamationHs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Num = c.String(),
                        Date = c.DateTime(nullable: false),
                        Réferance = c.String(),
                        CodeRep = c.String(),
                        Véhicule = c.String(),
                        CodeClient = c.String(),
                        NomClient = c.String(),
                        AdresseClient = c.String(),
                        MfClient = c.String(),
                        Tel = c.String(),
                        ErreurCMD = c.Boolean(nullable: false),
                        DommageTransport = c.Boolean(nullable: false),
                        PaiementNonDispo = c.Boolean(nullable: false),
                        ErreurFacturation = c.Boolean(nullable: false),
                        Note = c.String(),
                        ImageName = c.String(),
                        AutreRaisonRetour = c.Boolean(nullable: false),
                        DefFab = c.Boolean(nullable: false),
                        Casse = c.Boolean(nullable: false),
                        Décoloration = c.Boolean(nullable: false),
                        DateDePrémption = c.Boolean(nullable: false),
                        AutreRaisonEchange = c.Boolean(nullable: false),
                        Contact = c.String(),
                        IdSite = c.Int(nullable: false),
                        NomSite = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        Directeur = c.String(),
                        MobileDirecteur = c.String(),
                        ChefRayon = c.String(),
                        MobileChefRayon = c.String(),
                        Tel = c.String(),
                        Fax = c.String(),
                        Adresse = c.String(),
                        Gouvernorat = c.String(),
                        Ville = c.String(),
                        CodePostal = c.String(),
                        Email = c.String(),
                        EmailDirecteur = c.String(),
                        EmailChefRayon = c.String(),
                        FrequenceVisite = c.Int(nullable: false),
                        CategorieId = c.Int(),
                        ClientId = c.Int(nullable: false),
                        Latitude = c.Double(),
                        Longitude = c.Double(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SitesMarchandisers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UtilisateurId = c.Int(nullable: false),
                        SiteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TraceGPS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        Latitude = c.Double(),
                        Longitude = c.Double(),
                        DateCreation = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TraceGPSSites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdSite = c.Int(nullable: false),
                        IdMarchandiseur = c.Int(nullable: false),
                        Latitude = c.Double(),
                        Longitude = c.Double(),
                        DateCreation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeVisites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        IsAdmin = c.Boolean(),
                        IsMarchandiser = c.Boolean(),
                        IsPromotrice = c.Boolean(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Mail = c.String(),
                        NumeroTel = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Visites",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Subject = c.String(),
                        Status = c.Int(nullable: false),
                        Description = c.String(),
                        NoteMarchandiseur = c.String(),
                        Label = c.Int(nullable: false),
                        Location = c.String(),
                        AllDay = c.Boolean(nullable: false),
                        EventType = c.Int(nullable: false),
                        RecurrenceInfo = c.String(),
                        ReminderInfo = c.String(),
                        OwnerId = c.Int(nullable: false),
                        CustomInfo = c.String(),
                        CustomAttachment = c.Binary(),
                        CustomAttachmentFileName = c.String(),
                        NbArticleParSite = c.Int(),
                        NbArticleTotal = c.Int(),
                        PlanId = c.Int(nullable: false),
                        IdUser = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        DateModificationEtat = c.DateTime(nullable: false),
                        IdUserModificationEtat = c.Int(nullable: false),
                        DateVisite = c.DateTime(nullable: false),
                        LatitudeLastVisite = c.Double(),
                        LongitudeLastVisite = c.Double(),
                        SendReport = c.Boolean(nullable: false),
                        Site_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sites", t => t.Site_Id)
                .Index(t => t.Site_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visites", "Site_Id", "dbo.Sites");
            DropIndex("dbo.Visites", new[] { "Site_Id" });
            DropTable("dbo.Visites");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.TypeVisites");
            DropTable("dbo.TraceGPSSites");
            DropTable("dbo.TraceGPS");
            DropTable("dbo.SitesMarchandisers");
            DropTable("dbo.Sites");
            DropTable("dbo.ReclamationHs");
            DropTable("dbo.ReclamationDs");
            DropTable("dbo.Plans");
            DropTable("dbo.LigneRapportVisites");
            DropTable("dbo.FamilleClients");
            DropTable("dbo.ComputerDocuments");
            DropTable("dbo.ClientsMarchandisers");
            DropTable("dbo.Clients");
            DropTable("dbo.CategorieSiteClients");
            DropTable("dbo.Articles");
            DropTable("dbo.ArticleParSites");
        }
    }
}
