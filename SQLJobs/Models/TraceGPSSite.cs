using System;
using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class TraceGPSSite
    {
        [Key]
        public int Id { get; set; }
        public int IdSite { get; set; }
        public int IdMarchandiseur { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? DateCreation { get; set; }
    }
}