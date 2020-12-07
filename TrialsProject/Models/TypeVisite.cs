using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class TypeVisite
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
    }
}