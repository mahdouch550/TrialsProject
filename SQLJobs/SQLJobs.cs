using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialsProject.Models;
using Dapper;

namespace SQLJobs
{
    public class SQLJobs
    {
        private String SourceConnectionString;
        private String DestinationConnectionString;

        public SQLJobs(String SourceConnectionString, String DestinationConnectionString)
        {
            this.SourceConnectionString = SourceConnectionString;
            this.DestinationConnectionString = DestinationConnectionString;
        }

        public void UpdateDatabase()
        {
            //GetAndInsertAllArticles();
            //GetAndInsertAllCategorieSiteClients();
            //GetAndInsertAllFamilleClients();
            //GetAndInsertAllClients();
            //GetAndInsertAllSites();
            //GetAndInsertAllArticleParSites();
            //GetAndInsertAllUtilisateurs();
            GetAndInsertAllVisites();
            GetAndInsertAllLigneRapportVisites();
            GetAndInsertAllPlans();
            GetAndInsertAllTraceGPS();
            GetAndInsertAllTraceGPSSites();
            GetAndInsertAllTypeVisites();
            Console.WriteLine("Finished");
        }

        #region Select Scripts

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

        #region Insert Scripts

        private String ArticleParSitesInsertQuery = @"set identity_insert [GMN].[dbo].[ArticleParSites] on;insert into [GMN].[dbo].[ArticleParSites](
id,
[QteMin]
          ,[Site_Id]
          ,[Article_Id]
          ,[Prix])
          values (@Id, @QteMin, @SiteId, @ArticleId, @Prix); set identity_insert [GMN].[dbo].[ArticleParSites] off;";

        private String ArticlesInsertQuery = @"set identity_insert Articles on; insert into [GMN].[dbo].[Articles](
id,
[Code]
          ,[Libelle]
          ,[CodeEAN]
          ,[QteDansRayon]
          ,[Prix])
        values (@Id, @Code, @Libelle, @CodeEAN, @QteDansRayon, @Prix); set identity_insert Articles off;";

        private String CategorieSiteClientsInsertQuery = @"set identity_insert [GMN].[dbo].[CategorieSiteClients] on; insert into [GMN].[dbo].[CategorieSiteClients] 
           (id,
[Code]
          ,[Libelle]
          ,[Image])
        values (@Id, @Code, @Libelle, @Image); set identity_insert Articles off;";

        private String ClientsInsertQuery = @"set identity_insert [GMN].[dbo].[Clients] on; insert into [GMN].[dbo].[Clients]
       (id,
[Code]
      ,[RaisonSociale]
      ,[MatriculeFiscale]
      ,[Adresse]
      ,[Latitude]
      ,[Longitude]
      ,[IsDeleted]
      ,[FamilleId]
      ,[Tel]
      ,[Gouvernorat])
      values (@Id, @Code, @RaisonSociale, @MatriculeFiscale, @Adresse, @Latitude, @Longitude, @IsDeleted, @FamilleId, @Tel, @Gouvernorat); set identity_insert [GMN].[dbo].[Clients] off;";

        private String FamilleClientsInsertQuery = @"set identity_insert [GMN].[dbo].[FamilleClients] on; insert into[GMN].[dbo].[FamilleClients]
(id,
[Code]
      ,[Designation]
      ,[IsDeleted]
      ,[Stat]
      ,[Stat2])
values (@Id, @Code, @Designation, @IsDeleted, @Stat, @Stat2); set identity_insert [GMN].[dbo].[FamilleClients] off;";

        private String LigneRapportVisitesInsertQuery = @"set identity_insert [GMN].[dbo].[LigneRapportVisites] on; insert into [GMN].[dbo].[LigneRapportVisites]
([Id]
      ,[VisiteId]
      ,[ArticleId]
      ,[QteMin]
      ,[QteActuel]
      ,[Note]
      ,[Photo]
      ,[QteVendu]
      ,[QteReserve]
      ,[Prix])
values (@Id, @VisiteId, @ArticleId, @QteMin, @QteActuel, @Note, @Photo, @QteVendu, @QteReserve, @Prix); set identity_insert [GMN].[dbo].[LigneRapportVisites] off;";

        private String PlansInsertQuery = @"set identity_insert [GMN].[dbo].[Plans] on; insert into [GMN].[dbo].[Plans]
([Id]
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
      ,[IdMarchadiser])
values (@Id, @DateDebut, @DateFin, @DateValidation, @DateCreation, @DateDernierModification, @UserIdModif, @UserIdCreation,
@UserIdValidation, @Note, @IsValidated, @IdMarchadiser); set identity_insert [GMN].[dbo].[Plans] off;";

        private String SitesInsertQuery = @"set identity_insert [GMN].[dbo].[Sites] on; insert into [GMN].[dbo].[Sites]
(id,
[Libelle]
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
      ,[IsDeleted])
values (@Id, @Libelle, @Directeur, @MobileDirecteur, @ChefRayon, @MobileChefRayon, @Tel, @Fax, @Adresse, @Gouvernorat, @Ville, @CodePostal,
@Email, @EmailDirecteur, @EmailChefRayon, @FrequenceVisite, @CategorieId, @ClientId, @Latitude, @Longitude, @IsDeleted); set identity_insert [GMN].[dbo].[Sites] off;";

        private String TraceGPSInsertQuery = @"set identity_insert [GMN].[dbo].[TraceGPS] on; insert into [GMN].[dbo].[TraceGPS]
([Id]
      ,[IdUser]
      ,[Latitude]
      ,[Longitude]
      ,[DateCreation])
values (@Id, @IdUser, @Latitude, @Longitude, @DateCreation); set identity_insert [GMN].[dbo].[TraceGPS] off;";

        private String TraceGPSSitesInsertQuery = @"set identity_insert [GMN].[dbo].[TraceGPSSites] on;insert into [GMN].[dbo].[TraceGPSSites]
([Id]
      ,[IdSite]
      ,[IdMarchandiseur]
      ,[Latitude]
      ,[Longitude]
      ,[DateCreation])
values (@Id, @IdSite, @IdMarchandiseur, @Latitude, @Longitude, @DateCreation); set identity_insert [GMN].[dbo].[TraceGPSSites] off;";

        private String TypeVisitesInsertQuery = @"set identity_insert [GMN].[dbo].[TypeVisites] on; insert into [GMN].[dbo].[TypeVisites]
([Id]
      ,[Code]
      ,[Libelle])
values (@Id, @Code, @Libelle); set identity_insert [GMN].[dbo].[TypeVisites] off;";

        private String UtilisateursInsertQuery = @"set identity_insert [GMN].[dbo].[Utilisateurs] on; insert into [GMN].[dbo].[Utilisateurs]
([Id]
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
      ,[IsPromotrice])
values (@Id, @Matricule, @Login, @Password, @IsAdmin, @IsMarchandiser, @Nom, @Prenom, @Mail, @NumeroTel, @IsDeleted, @IsPromotrice); set identity_insert [GMN].[dbo].[Utilisateurs] off;";

        private String VisitesInsertQuery = @"set identity_insert [GMN].[dbo].[Visites] on; insert into [GMN].[dbo].[Visites]
([ID]
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
      ,[Plan_Id]
      ,[Client_Id]
      ,[DateModificationEtat]
      ,[IdUserModificationEtat]
      ,[Site_Id]
      ,[DateVisite]
      ,[LatitudeLastVisite]
      ,[LongitudeLastVisite]
      ,[SendReport]
      ,[NbArticleParSite]
      ,[NbArticleTotal]
      ,[OwnerId]
      ,[User_ID])
values (@ID, @StartTime, @EndTime, @Subject, @Status, @Description, @NoteMarchandiseur, @Label, @Location, @AllDay, @EventType,
@RecurrenceInfo, @ReminderInfo, @CustomInfo, @CustomAttachment, @CustomAttachmentFileName, @PlanId, @ClientId, @DateModificationEtat,
@IdUserModificationEtat, @SiteId, @DateVisite, @LatitudeLastVisite, @LongitudeLastVisite, @SendReport, @NbArticleParSite, @NbArticleTotal,
@OwnerId, @IdUser); set identity_insert [GMN].[dbo].[Visites] off;";
        #endregion

        #region Methods
        private bool GetAndInsertAllArticles()
        {
            var output = new List<Article>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<Article>(ArticlesSelectQuery).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(ArticlesInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllCategorieSiteClients()
        {
            var output = new List<CategorieSiteClient>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<CategorieSiteClient>(CategorieSiteClientsSelectQuery).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(CategorieSiteClientsInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllArticleParSites()
        {
            var output = new List<ArticleParSite>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<ArticleParSite>(ArticleParSitesSelectQuery).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(ArticleParSitesInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllClients()
        {
            var output = new List<Client>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<Client>(ClientsSelectQuery).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(ClientsInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllFamilleClients()
        {
            var output = new List<FamilleClient>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<FamilleClient>(FamilleClientsSelectQuery).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(FamilleClientsInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllLigneRapportVisites()
        {
            var output = new List<LigneRapportVisite>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<LigneRapportVisite>(LigneRapportVisitesSelectQuery).Take(1000).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(LigneRapportVisitesInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllPlans()
        {
            var output = new List<Plan>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<Plan>(PlansSelectQuery).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(PlansInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllSites()
        {
            var output = new List<Site>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<Site>(SitesSelectQuery).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(SitesInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllTraceGPS()
        {
            var output = new List<TraceGPS>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<TraceGPS>(TraceGPSSelectQuery).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(TraceGPSInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllTraceGPSSites()
        {
            var output = new List<TraceGPSSite>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<TraceGPSSite>(TraceGPSSitesSelectQuery).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(TraceGPSSitesInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllTypeVisites()
        {
            var output = new List<TypeVisite>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<TypeVisite>(TypeVisitesSelectQuery).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(TypeVisitesInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllUtilisateurs()
        {
            var output = new List<Utilisateur>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<Utilisateur>(UtilisateursSelectQuery).ToList();
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(UtilisateursInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        private bool GetAndInsertAllVisites()
        {
            var output = new List<Visite>();
            using (var connection = new SqlConnection(SourceConnectionString))
            {
                output = connection.Query<Visite>(VisitesSelectQuery).ToList();
                output.Add(new Visite
                {
                    ID = 0,
                    Status =0,
                    Label = 0,
                    AllDay = false,
                    EventType = 0,
                    OwnerId = 0,
                    IdUserModificationEtat=0,
                    SendReport = false,                    
                });
                connection.Close();
            }
            using (var connection = new SqlConnection(DestinationConnectionString))
            {
                connection.Execute(VisitesInsertQuery, output);
                connection.Close();
            }
            return true;
        }
        #endregion
    }
}