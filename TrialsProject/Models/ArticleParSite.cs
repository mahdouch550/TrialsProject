﻿using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class ArticleParSite
    {
        [Key]
        public int Id { get; set; }
        public decimal QteMin { get; set; }
        public decimal Prix { get; set; }
        public int Site_Id { get; set; }
        public int Article_Id { get; set; }
    }
}