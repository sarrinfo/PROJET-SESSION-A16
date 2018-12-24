using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetSessionCoursA15.Models
{
    public class Image
    {
        [Required]
        public int BIENID { get; set; }
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }

        public BienImmobilier BIENIMMOBILIER { get; set; }

    }
}