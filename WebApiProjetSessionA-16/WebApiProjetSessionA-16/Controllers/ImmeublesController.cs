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
    public class ImmeublesController : ApiController
    {
        private WebApiProjetSessionA_16Context db = new WebApiProjetSessionA_16Context();

        // GET: api/Immeubles
        public IQueryable<Immeuble> GetImmeubles()
        {
            return db.Immeubles.Include(b => b.BIENIMMOBILIERS);
        }

        // GET: api/Immeubles/5
        [ResponseType(typeof(Immeuble))]
        public async Task<IHttpActionResult> GetImmeuble(string id)
        {
            Immeuble immeuble = await db.Immeubles.Include(a => a.BIENIMMOBILIERS).SingleOrDefaultAsync(a => a.ImmeubleID == id);
            if (immeuble == null)
            {
                return NotFound();
            }

            return Ok(immeuble);
        }

        // PUT: api/Immeubles/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutImmeuble(string id, Immeuble immeuble)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != immeuble.ImmeubleID)
            {
                return BadRequest();
            }

            db.Entry(immeuble).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImmeubleExists(id))
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

        // POST: api/Immeubles
        [ResponseType(typeof(Immeuble))]
        public async Task<IHttpActionResult> PostImmeuble(Immeuble immeuble)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Immeubles.Add(immeuble);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ImmeubleExists(immeuble.ImmeubleID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = immeuble.ImmeubleID }, immeuble);
        }

        // DELETE: api/Immeubles/5
        [ResponseType(typeof(Immeuble))]
        public async Task<IHttpActionResult> DeleteImmeuble(string id)
        {
            Immeuble immeuble = await db.Immeubles.FindAsync(id);
            if (immeuble == null)
            {
                return NotFound();
            }

            db.Immeubles.Remove(immeuble);
            await db.SaveChangesAsync();

            return Ok(immeuble);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ImmeubleExists(string id)
        {
            return db.Immeubles.Count(e => e.ImmeubleID == id) > 0;
        }
    }
}