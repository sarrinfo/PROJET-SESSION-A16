using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetSessionCoursA15.Models
{
    public class Immeuble
    {
        [Key]
        public string ImmeubleID { get; set; }
        public string Photos { get; set; }
        [Required]
        [DisplayName("Annee construction")]
        public Nullable<System.DateTime> AnneeConstruction { get; set; }
        public int AdresseId { get; set; }
        [DisplayName("Type")]
        public string Type_Immeuble { get; set; }

        public Adresse ADDRESSE { get; set; }
        public List<BienImmobilier> BIENIMMOBILIERS { get; set; }
    }
}