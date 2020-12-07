using System;
using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        public String Code { get; set; }

        public String Libelle { get; set; }

        public String CodeEAN { get; set; }

        public decimal QteDansRayon { get; set; }

        public decimal Prix { get; set; }
    }
}