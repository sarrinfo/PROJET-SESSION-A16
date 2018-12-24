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
    public class BienImmobiliersController : ApiController
    {
        private WebApiProjetSessionA_16Context db = new WebApiProjetSessionA_16Context();

        // GET: api/BienImmobiliers
        public IQueryable<BienImmobilier> GetBienImmobiliers()
        {
            return db.BienImmobiliers.Include(b => b.IMMEUBLE.ADDRESSE).Include(i => i.IMAGES);
        }

        // GET: api/BienImmobiliers/5
        [ResponseType(typeof(BienImmobilier))]
        public async Task<IHttpActionResult> GetBienImmobilier(int id)
        {
            BienImmobilier bienImmobilier = await db.BienImmobiliers
                .Include(i => i.IMAGES)
                .Include(b => b.IMMEUBLE.ADDRESSE)
                .SingleOrDefaultAsync(a => a.BienID == id);
                
                
            if (bienImmobilier == null)
            {
                return NotFound();
            }

            return Ok(bienImmobilier);
        }


        // PUT: api/BienImmobiliers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBienImmobilier(int id, BienImmobilier bienImmobilier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bienImmobilier.BienID)
            {
                return BadRequest();
            }

            db.Entry(bienImmobilier).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BienImmobilierExists(id))
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

        // POST: api/BienImmobiliers
        [ResponseType(typeof(BienImmobilier))]
        public async Task<IHttpActionResult> PostBienImmobilier(BienImmobilier bienImmobilier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BienImmobiliers.Add(bienImmobilier);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = bienImmobilier.BienID }, bienImmobilier);
        }

        // DELETE: api/BienImmobiliers/5
        [ResponseType(typeof(BienImmobilier))]
        public async Task<IHttpActionResult> DeleteBienImmobilier(int id)
        {
            BienImmobilier bienImmobilier = await db.BienImmobiliers.FindAsync(id);
            if (bienImmobilier == null)
            {
                return NotFound();
            }

            db.BienImmobiliers.Remove(bienImmobilier);
            await db.SaveChangesAsync();

            return Ok(bienImmobilier);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BienImmobilierExists(int id)
        {
            return db.BienImmobiliers.Count(e => e.BienID == id) > 0;
        }
    }
}