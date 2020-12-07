using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class ClientsMarchandiser
    {
        [Key]
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public int ClientId { get; set; }
    }
}
