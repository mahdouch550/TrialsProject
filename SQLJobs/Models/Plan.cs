using System;
using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class Plan
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateDebut { get; set; } = DateTime.Today;
        public DateTime DateFin { get; set; } = DateTime.Today.AddMonths(1).AddDays(-1);
        public DateTime? DateValidation { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateDernierModification { get; set; }
        public int IdMarchadiser { get; set; }
        public int UserIdModif { get; set; }
        public int UserIdCreation { get; set; }
        public int? UserIdValidation { get; set; }
        public string Note { get; set; }
        public bool IsValidated { get; set; }
    }
}