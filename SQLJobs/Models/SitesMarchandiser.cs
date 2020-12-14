using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class SitesMarchandiser
    {
        [Key]
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public int SiteId { get; set; }
    }
}