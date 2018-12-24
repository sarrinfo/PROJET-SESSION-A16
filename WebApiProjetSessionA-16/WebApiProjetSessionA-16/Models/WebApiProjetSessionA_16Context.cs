using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiProjetSessionA_16.Models
{
    public class WebApiProjetSessionA_16Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApiProjetSessionA_16Context() : base("name=WebApiProjetSessionA_16Context")
        {
        }

        public System.Data.Entity.DbSet<WebApiProjetSessionA_16.Models.Annonce> Annonces { get; set; }

        public System.Data.Entity.DbSet<WebApiProjetSessionA_16.Models.BienImmobilier> BienImmobiliers { get; set; }

        public System.Data.Entity.DbSet<WebApiProjetSessionA_16.Models.Immeuble> Immeubles { get; set; }

        public System.Data.Entity.DbSet<WebApiProjetSessionA_16.Models.Adresse> Adresses { get; set; }

        public System.Data.Entity.DbSet<WebApiProjetSessionA_16.Models.Visite> Visites { get; set; }

        public System.Data.Entity.DbSet<WebApiProjetSessionA_16.Models.Employe> Employes { get; set; }

        public System.Data.Entity.DbSet<WebApiProjetSessionA_16.Models.Visiteur> Visiteurs { get; set; }
    }
}
