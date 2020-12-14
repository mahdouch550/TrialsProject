using System.ComponentModel.DataAnnotations;

namespace TrialsProject.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        private bool isAdmin;
        public bool? IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value ?? false; }
        }
        private bool isMarchandiser;
        public bool? IsMarchandiser
        {
            get { return isMarchandiser; }
            set { isMarchandiser = value ?? false; }
        }
        private bool isPromotrice;
        public bool? IsPromotrice
        {
            get { return isPromotrice; }
            set { isPromotrice = value ?? false; }
        }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string NumeroTel { get; set; }
        public bool IsDeleted { get; set; }
    }
}