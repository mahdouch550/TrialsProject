using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class Site
    {
        [Key]
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Directeur { get; set; }
        public string MobileDirecteur { get; set; }
        public string ChefRayon { get; set; }
        public string MobileChefRayon { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Adresse { get; set; }
        public string Gouvernorat { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Email { get; set; }
        public string EmailDirecteur { get; set; }
        public string EmailChefRayon { get; set; }
        public int FrequenceVisite { get; set; }
        public int? CategorieId { get; set; }
        public int ClientId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool IsDeleted { get; set; }
    }
}
