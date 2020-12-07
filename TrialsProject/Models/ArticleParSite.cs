using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class ArticleParSite
    {
        [Key]
        public int Id { get; set; }
        public decimal QteMin { get; set; }
        public decimal Prix { get; set; }
        public int SiteId { get; set; }
        public int ArticleId { get; set; }
    }
}