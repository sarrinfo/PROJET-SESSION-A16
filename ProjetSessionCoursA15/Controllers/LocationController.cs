
using ProjetSessionCoursA15.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ProjetSessionA16.Controllers
{
    [Authorize]
    public class LocationController : Controller
    {
        [AllowAnonymous]
        // GET: Location
        public ActionResult Index()
        {
            IEnumerable<Annonce> annonce = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50391/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Annonces");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Annonce>>();
                    readTask.Wait();

                    annonce = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    annonce = Enumerable.Empty<Annonce>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
                return View(annonce);
            }

        }
        [AllowAnonymous]
        // GET: Location/Details/5
        public ActionResult Details(int id)
        {
            BienImmobilier bien = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50391/api/");
                //HTTP GET
                var responseTask = client.GetAsync("BienImmobiliers/"+id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<BienImmobilier>();
                    readTask.Wait();

                    bien = readTask.Result;
                }
     
                return View(bien);
            }
        }

        // GET: Location/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Location/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Location/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Visite (int id)
        {
            IEnumerable<Visite> visite = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50391/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Visites/" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Visite>>();
                    readTask.Wait();

                    visite = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    visite = Enumerable.Empty<Visite>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
                return View(visite);
            }
        }
    }
}
