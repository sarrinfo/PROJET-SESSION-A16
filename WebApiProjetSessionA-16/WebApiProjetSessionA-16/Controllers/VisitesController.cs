using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiProjetSessionA_16.Models;

namespace WebApiProjetSessionA_16.Controllers
{
    public class VisitesController : ApiController
    {
        private WebApiProjetSessionA_16Context db = new WebApiProjetSessionA_16Context();

        // GET: api/Visites
        public IQueryable<Visite> GetVisites(int Id)
        {
            return db.Visites.Include(b => b.BIENIMMOBILIER).Include(e => e.EMPLOYE).Where(p => p.BIENIMMOBILIER.BienID == Id);
        }

        // GET: api/Visites/5
        //[ResponseType(typeof(Visite))]
        //public async Task<IHttpActionResult> GetVisite(int id)
        //{
        //    Visite visite = await db.Visites.FindAsync(id);
        //    if (visite == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(visite);
        //}

        // PUT: api/Visites/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVisite(int id, Visite visite)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != visite.Id)
            {
                return BadRequest();
            }

            db.Entry(visite).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisiteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Visites
        [ResponseType(typeof(Visite))]
        public async Task<IHttpActionResult> PostVisite(Visite visite)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Visites.Add(visite);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = visite.Id }, visite);
        }

        // DELETE: api/Visites/5
        [ResponseType(typeof(Visite))]
        public async Task<IHttpActionResult> DeleteVisite(int id)
        {
            Visite visite = await db.Visites.FindAsync(id);
            if (visite == null)
            {
                return NotFound();
            }

            db.Visites.Remove(visite);
            await db.SaveChangesAsync();

            return Ok(visite);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VisiteExists(int id)
        {
            return db.Visites.Count(e => e.Id == id) > 0;
        }
    }
}