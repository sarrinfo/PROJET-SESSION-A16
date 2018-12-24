using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetSessionCoursA15.Models
{
    public class Employe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }

        public string Prenom { get; set; }
        [Required]
        public string Contact { get; set; }
    }
}