using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class FamilleClient
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Designation { get; set; }
        public bool IsDeleted { get; set; }
        public int Stat { get; set; }
        public int Stat2 { get; set; }
    }
}