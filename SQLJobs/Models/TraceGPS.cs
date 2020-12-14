using System;
using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class TraceGPS
    {
        [Key]
        public int Id { get; set; }
        public int IdUser { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? DateCreation { get; set; }
    }
}