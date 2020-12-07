using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class LigneRapportVisite
    {
        [Key]
        public int Id { get; set; }
        public int VisiteId { get; set; }
        public int ArticleId { get; set; }
        public decimal QteMin { get; set; }
        public decimal? QteActuel { get; set; }
        public string Note { get; set; }
        public byte[] Photo { get; set; }
        public decimal? QteVendu { get; set; }
        public decimal? QteReserve { get; set; }
        public decimal? Prix { get; set; }
    }
}
