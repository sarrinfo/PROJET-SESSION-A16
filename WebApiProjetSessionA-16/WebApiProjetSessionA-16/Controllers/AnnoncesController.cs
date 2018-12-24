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
    public class AnnoncesController : ApiController
    {
        private WebApiProjetSessionA_16Context db = new WebApiProjetSessionA_16Context();

        // GET: api/Annonces
        public IQueryable<Annonce> GetAnnonces()
        {
            return db.Annonces.Include(b => b.BIENIMMOBILIER);
        }

        // GET: api/Annonces/5
        [ResponseType(typeof(Annonce))]
        public async Task<IHttpActionResult> GetAnnonce(int id)
        {
            Annonce annonce = await db.Annonces.Include(a => a.BIENIMMOBILIER).SingleOrDefaultAsync(a => a.Id == id);
            if (annonce == null)
            {
                return NotFound();
            }

            return Ok(annonce);
        }

        // PUT: api/Annonces/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAnnonce(int id, Annonce annonce)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != annonce.Id)
            {
                return BadRequest();
            }

            db.Entry(annonce).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnnonceExists(id))
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

        // POST: api/Annonces
        [ResponseType(typeof(Annonce))]
        public async Task<IHttpActionResult> PostAnnonce(Annonce annonce)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Annonces.Add(annonce);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = annonce.Id }, annonce);
        }

        // DELETE: api/Annonces/5
        [ResponseType(typeof(Annonce))]
        public async Task<IHttpActionResult> DeleteAnnonce(int id)
        {
            Annonce annonce = await db.Annonces.Include(a => a.BIENIMMOBILIER).SingleOrDefaultAsync(a => a.Id == id);
            if (annonce == null)
            {
                return NotFound();
            }

            db.Annonces.Remove(annonce);
            await db.SaveChangesAsync();

            return Ok(annonce);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AnnonceExists(int id)
        {
            return db.Annonces.Count(e => e.Id == id) > 0;
        }
    }
}