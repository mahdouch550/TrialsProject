using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialsProject.Models;

namespace TrialsProject.DTS
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base(ConfigurationManager.ConnectionStrings["SourceDatabaseConnectionString"].ConnectionString)
        {
            //Database.SetInitializer<AppDbContext>(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.Configuration>());
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleParSite> ArticleParSites { get; set; }
        public DbSet<CategorieSiteClient> CategorieSiteClients { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientsMarchandiser> ClientsMarchandisers { get; set; }
        public DbSet<ComputerDocument> ComputerDocuments { get; set; }
        public DbSet<FamilleClient> FamilleClients { get; set; }
        public DbSet<LigneRapportVisite> LigneRapportVisites { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<ReclamationD> ReclamationDs { get; set; }
        public DbSet<ReclamationH> ReclamationHs { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<SitesMarchandiser> SitesMarchandisers { get; set; }
        public DbSet<TraceGPS> TraceGPSs { get; set; }
        public DbSet<TraceGPSSite> TraceGPSSites { get; set; }
        public DbSet<TypeVisite> TypeVisites { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Visite> Visites { get; set; }
    }
}