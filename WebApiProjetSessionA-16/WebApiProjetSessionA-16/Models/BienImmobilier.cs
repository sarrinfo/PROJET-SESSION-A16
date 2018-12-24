using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiProjetSessionA_16.Models
{
    public class BienImmobilier
    {
        
        [Key]
        public int BienID { get; set; }
        [Required]
        public string ImmeubleID { get; set; }
        [DisplayName("Type")]
        public string Type_BIENIMMOBILIER { get; set; }

        [DisplayName("Prix loyer")]
        public Nullable<double> Prix_loyer { get; set; }


        public Immeuble IMMEUBLE { get; set; }

        public List<Image> IMAGES { get; set; }

    }
}