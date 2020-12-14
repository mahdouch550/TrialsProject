using System;
using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class ReclamationD
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Reclamation { get; set; }
        public String CodeProduit { get; set; }
        public String Désignation { get; set; }
        public decimal Qt { get; set; }
        public String NLot { get; set; }
        public DateTime? DateFabric { get; set; }
        public String NFact { get; set; }
        public DateTime? DateFac { get; set; }
        public String Observations { get; set; }
        public bool DécisionRetour { get; set; }
        public int Ordre { get; set; }
        public String ImageName { get; set; }
    }
}