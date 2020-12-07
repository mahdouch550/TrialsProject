using System;
using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class ReclamationH
    {
        [Key]
        public Guid Id { get; set; }
        public String Num { get; set; }
        public DateTime? Date { get; set; }
        public String Réferance { get; set; }
        public String CodeRep { get; set; }
        public String Véhicule { get; set; }
        public String CodeClient { get; set; }
        public String NomClient { get; set; }
        public String AdresseClient { get; set; }
        public String MfClient { get; set; }
        public String Tel { get; set; }
        public bool ErreurCMD { get; set; }
        public bool DommageTransport { get; set; }
        public bool PaiementNonDispo { get; set; }
        public bool ErreurFacturation { get; set; }
        public String Note { get; set; }
        public String ImageName { get; set; }
        public bool AutreRaisonRetour { get; set; }
        public bool DefFab { get; set; }
        public bool Casse { get; set; }
        public bool Décoloration { get; set; }
        public bool DateDePrémption { get; set; }
        public bool AutreRaisonEchange { get; set; }
        public String Contact { get; set; }
        public int IdSite { get; set; }
        public String NomSite { get; set; }
    }
}