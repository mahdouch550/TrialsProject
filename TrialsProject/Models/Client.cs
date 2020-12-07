using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string RaisonSociale { get; set; }
        public string MatriculeFiscale { get; set; }
        public string Adresse { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool IsDeleted { get; set; }
        public string Tel { get; set; }
        public string Gouvernorat { get; set; }
        public int? FamilleId { get; set; }
    }
}