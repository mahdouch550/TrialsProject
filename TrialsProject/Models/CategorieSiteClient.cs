using System;
using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class CategorieSiteClient
    {
        [Key]
        public int Id { get; set; }
        public String Code { get; set; }
        public String Libelle { get; set; }
        public byte[] Image { get; set; }
    }
}