using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiProjetSessionA_16.Models
{
    public class Adresse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CodePostal { get; set; }
        [Required]
        public int Numero { get; set; }
        public string Rue { get; set; }
        public string Localite { get; set; }
        public string Ville { get; set; }


        public List<Immeuble> IMMEUBLES { get; set; }
    }
}
