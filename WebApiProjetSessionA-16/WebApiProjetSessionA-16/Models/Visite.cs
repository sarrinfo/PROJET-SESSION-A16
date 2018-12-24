using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiProjetSessionA_16.Models
{
    public class Visite
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Date visite")]
        public DateTime Datevisite { get; set; }
        public Nullable<int> VisiteurId { get; set; }
        [Required]
        public int EmployeId {get; set; }
        [Required]
        public int BienImmobilierBienId { get; set; }

        public BienImmobilier BIENIMMOBILIER { get; set; }

        public Visiteur VISITEUR { get; set; }

        public Employe EMPLOYE { get; set; }

    }
}