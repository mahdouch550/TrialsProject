using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using TrialsProject.Models;

namespace TrialsProject
{
    public class SqlJobs
    {
        #region Scripts

        private String ArticleParSitesSelectQuery = @"SELECT 
           [Id]
          ,[QteMin]
          ,[SiteId]
          ,[ArticleId]
          ,[Prix]
        FROM [GMN].[dbo].[ArticleParSites]";

        private String ArticlesSelectQuery = @"SELECT 
           [Id]
          ,[Code]
          ,[Libelle]
          ,[CodeEAN]
          ,[QteDansRayon]
          ,[Prix]
        FROM [GMN].[dbo].[Articles]";

        private String CategorieSiteClientsSelectQuery = @"SELECT 
           [Id]
          ,[Code]
          ,[Libelle]
          ,[Image]
        FROM [GMN].[dbo].[CategorieSiteClients]";

        private String ClientsSelectQuery = @"SELECT [Id]
      ,[Code]
      ,[RaisonSociale]
      ,[MatriculeFiscale]
      ,[Adresse]
      ,[Latitude]
      ,[Longitude]
      ,[IsDeleted]
      ,[FamilleId]
      ,[Tel]
      ,[Gouvernorat]
  FROM [GMN].[dbo].[Clients]";

        private String ClientsMarchandiserSelectQuery = @"SELECT [UtilisateurId]
      ,[ClientId]
  FROM [GMN].[dbo].[ClientsMarchandiser]";

        private String ComputerDocumentSelectQuery = @"SELECT [Id]
      ,[Code]
      ,[Début]
      ,[Dernier]
      ,[Format]
  FROM [GMN].[dbo].[CompteurDocument]";

        private String FamilleClientsSelectQuery = @"SELECT [Id]
      ,[Code]
      ,[Designation]
      ,[IsDeleted]
      ,[Stat]
      ,[Stat2]
  FROM [GMN].[dbo].[FamilleClients]";

        private String LigneRapportVisitesSelectQuery = @"SELECT [Id]
      ,[VisiteId]
      ,[ArticleId]
      ,[QteMin]
      ,[QteActuel]
      ,[Note]
      ,[Photo]
      ,[QteVendu]
      ,[QteReserve]
      ,[Prix]
  FROM [GMN].[dbo].[LigneRapportVisites]";

        private String PlansSelectQuery = @"SELECT [Id]
      ,[DateDebut]
      ,[DateFin]
      ,[DateValidation]
      ,[DateCreation]
      ,[DateDernierModification]
      ,[UserIdModif]
      ,[UserIdCreation]
      ,[UserIdValidation]
      ,[Note]
      ,[IsValidated]
      ,[IdMarchadiser]
  FROM [GMN].[dbo].[Plans]";

        private String ReclamationDSelectQuery = @"SELECT [Id]
      ,[Reclamation]
      ,[CodeProduit]
      ,[Désignation]
      ,[Qt]
      ,[NLot]
      ,[DateFabric]
      ,[NFact]
      ,[DateFac]
      ,[Observations]
      ,[DécisionRetour]
      ,[Ordre]
      ,[ImageName]
  FROM [GMN].[dbo].[ReclamationD]";

        private String ReclamationHSelectQuery = @"SELECT [Id]
      ,[Num]
      ,[Date]
      ,[Réferance]
      ,[CodeRep]
      ,[Véhicule]
      ,[CodeClient]
      ,[NomClient]
      ,[AdresseClient]
      ,[MfClient]
      ,[Tel]
      ,[ErreurCMD]
      ,[DommageTransport]
      ,[PaiementNonDispo]
      ,[ErreurFacturation]
      ,[Note]
      ,[ImageName]
      ,[AutreRaisonRetour]
      ,[DefFab]
      ,[Casse]
      ,[Décoloration]
      ,[DateDePrémption]
      ,[AutreRaisonEchange]
      ,[Contact]
      ,[IdSite]
      ,[NomSite]
  FROM [GMN].[dbo].[ReclamationH]";

        private String SitesSelectQuery = @"SELECT [Id]
      ,[Libelle]
      ,[Directeur]
      ,[MobileDirecteur]
      ,[ChefRayon]
      ,[MobileChefRayon]
      ,[Tel]
      ,[Fax]
      ,[Adresse]
      ,[Gouvernorat]
      ,[Ville]
      ,[CodePostal]
      ,[Email]
      ,[EmailDirecteur]
      ,[EmailChefRayon]
      ,[FrequenceVisite]
      ,[CategorieId]
      ,[ClientId]
      ,[Latitude]
      ,[Longitude]
      ,[IsDeleted]
  FROM [GMN].[dbo].[Sites]";

        private String SitesMarchandiserSelectQuery = @"SELECT [UtilisateurId]
      ,[SiteId]
  FROM [GMN].[dbo].[SitesMarchandiser]";

        private String TraceGPSSelectQuery = @"SELECT [Id]
      ,[IdUser]
      ,[Latitude]
      ,[Longitude]
      ,[DateCreation]
  FROM [GMN].[dbo].[TraceGPS]";

        private String TraceGPSSitesSelectQuery = @"SELECT [Id]
      ,[IdSite]
      ,[IdMarchandiseur]
      ,[Latitude]
      ,[Longitude]
      ,[DateCreation]
  FROM [GMN].[dbo].[TraceGPSSites]";

        private String TypeVisitesSelectQuery = @"SELECT [Id]
      ,[Code]
      ,[Libelle]
  FROM [GMN].[dbo].[TypeVisites]";

        private String UtilisateursSelectQuery = @"SELECT [Id]
      ,[Matricule]
      ,[Login]
      ,[Password]
      ,[IsAdmin]
      ,[IsMarchandiser]
      ,[Nom]
      ,[Prenom]
      ,[Mail]
      ,[NumeroTel]
      ,[IsDeleted]
      ,[IsPromotrice]
  FROM [GMN].[dbo].[Utilisateurs]";

        private String VisitesSelectQuery = @"SELECT [ID]
      ,[StartTime]
      ,[EndTime]
      ,[Subject]
      ,[Status]
      ,[Description]
      ,[NoteMarchandiseur]
      ,[Label]
      ,[Location]
      ,[AllDay]
      ,[EventType]
      ,[RecurrenceInfo]
      ,[ReminderInfo]
      ,[CustomInfo]
      ,[CustomAttachment]
      ,[CustomAttachmentFileName]
      ,[PlanId]
      ,[ClientId]
      ,[DateModificationEtat]
      ,[IdUserModificationEtat]
      ,[SiteId]
      ,[DateVisite]
      ,[LatitudeLastVisite]
      ,[LongitudeLastVisite]
      ,[SendReport]
      ,[NbArticleParSite]
      ,[NbArticleTotal]
      ,[OwnerId]
      ,[IdUser]
  FROM [GMN].[dbo].[Visites]";
        #endregion

        #region Methods

        public List<ArticleParSite> GetAllArticleParSites()
        {
            var output = new List<ArticleParSite>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<ArticleParSite>(ArticleParSitesSelectQuery).ToList(); 
                connection.Close();
            }
            return output;
        }

        public List<Article> GetAllArticles()
        {
            var output = new List<Article>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<Article>(ArticlesSelectQuery).ToList(); 
                connection.Close();
            }
            return output;
        }

        public List<CategorieSiteClient> GetAllCategorieSiteClients()
        {
            var output = new List<CategorieSiteClient>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<CategorieSiteClient>(CategorieSiteClientsSelectQuery).ToList();
                connection.Close();
            }
            return output;
        }

        public List<Client> GetAllClients()
        {
            var output = new List<Client>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<Client>(ClientsSelectQuery).ToList();
                connection.Close();
            }
            return output;
        }

        public List<ClientsMarchandiser> GetAllClientsMarchandiser()
        {
            var output = new List<ClientsMarchandiser>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<ClientsMarchandiser>(ClientsMarchandiserSelectQuery).ToList(); 
                connection.Close();
            }
            return output;
        }

        public List<ComputerDocument> GetAllComputerDocument()
        {
            var output = new List<ComputerDocument>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<ComputerDocument>(ComputerDocumentSelectQuery).ToList(); 
                connection.Close();
            }
            return output;
        }

        public List<FamilleClient> GetAllFamilleClients()
        {
            var output = new List<FamilleClient>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<FamilleClient>(FamilleClientsSelectQuery).ToList(); 
                connection.Close();
            }
            return output;
        }

        public List<LigneRapportVisite> GetAllLigneRapportVisites()
        {
            var output = new List<LigneRapportVisite>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<LigneRapportVisite>(LigneRapportVisitesSelectQuery).ToList(); 
                connection.Close();
            }
            return output;
        }

        public List<Plan> GetAllPlans()
        {
            var output = new List<Plan>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<Plan>(PlansSelectQuery).ToList(); 
                connection.Close();
            }
            return output;
        }

        public List<ReclamationD> GetAllReclamationD()
        {
            var output = new List<ReclamationD>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<ReclamationD>(ReclamationDSelectQuery).ToList();
                connection.Close();
            }
            return output;
        }

        public List<ReclamationH> GetAllReclamationH()
        {
            var output = new List<ReclamationH>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<ReclamationH>(ReclamationHSelectQuery).ToList(); 
                connection.Close();
            }
            return output;
        }

        public List<Site> GetAllSites()
        {
            var output = new List<Site>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<Site>(SitesSelectQuery).ToList(); 
                connection.Close();
            }
            return output;
        }

        public List<SitesMarchandiser> GetAllSitesMarchandiser()
        {
            var output = new List<SitesMarchandiser>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<SitesMarchandiser>(SitesMarchandiserSelectQuery).ToList();
                connection.Close();
            }
            return output;
        }

        public List<TraceGPS> GetAllTraceGPS()
        {
            var output = new List<TraceGPS>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<TraceGPS>(TraceGPSSelectQuery).ToList(); 
                connection.Close();
            }
            return output;
        }

        public List<TraceGPSSite> GetAllTraceGPSSites()
        {
            var output = new List<TraceGPSSite>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<TraceGPSSite>(TraceGPSSitesSelectQuery).ToList();
                connection.Close();
            }
            return output;
        }

        public List<TypeVisite> GetAllTypeVisites()
        {
            var output = new List<TypeVisite>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<TypeVisite>(TypeVisitesSelectQuery).ToList();
                connection.Close();
            }
            return output;
        }

        public List<Utilisateur> GetAllUtilisateurs()
        {
            var output = new List<Utilisateur>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<Utilisateur>(UtilisateursSelectQuery).ToList();
                connection.Close();
            }
            return output;
        }

        public List<Visite> GetAllVisites()
        {
            var output = new List<Visite>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BackupDatabaseConnectionString"].ConnectionString))
            {
                output = connection.Query<Visite>(VisitesSelectQuery).ToList(); 
                connection.Close();
            }
            return output;
        }
        #endregion
    }
}