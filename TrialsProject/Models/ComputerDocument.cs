using System;
using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class ComputerDocument
    {
        [Key]
        public int Id { get; set; }
        public String Code { get; set; }
        public int Dernier { get; set; }
        public String Format { get; set; }
    }
}