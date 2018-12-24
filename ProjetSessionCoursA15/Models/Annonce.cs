using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetSessionCoursA15.Models
{
    public class Annonce
    {
        [Key]
        public int Id { get; set; }
        public string Photos { get; set; }
        [Required]
        public string Titre { get; set; }
        [DisplayName("Nombre de piece")]
        public Nullable<int> NombrePieces { get; set; }
        [DisplayName("Nombre sdb")]
        public Nullable<int> NombreSDB { get; set; }
        public Nullable<int> Surface { get; set; }
        public string Inclusion { get; set; }
        public string Exclusion { get; set; }
        [DisplayName("Description")]
        public string AutresDescription { get; set; }
        [Required]
        public int BIENID { get; set; }

        public BienImmobilier BIENIMMOBILIER { get; set; }
    }
}