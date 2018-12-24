using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiProjetSessionA_16.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nom utilisateur")]
        public string Username { get; set; }
        [DisplayName("Mot de passe")]
        public string Password { get; set; }

        [DisplayName("Adresse email")]
        public string email { get; set; }
    }
}