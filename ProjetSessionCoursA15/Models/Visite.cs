using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetSessionCoursA15.Models
{
    public class Visite
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Date visite")]
        public DateTime Datevisite { get; set; }
        [DisplayName("Visiteur")]
        public Nullable<int> VisiteurId { get; set; }
        [DisplayName("Courtier")]
        [Required]
        public int EmployeId { get; set; }
        [DisplayName("Code Bien")]
        [Required]
        public int BienImmobilierBienId { get; set; }

        public BienImmobilier BIENIMMOBILIER { get; set; }

        public Visiteur VISITEUR { get; set; }

        public Employe EMPLOYE { get; set; }
    }
}