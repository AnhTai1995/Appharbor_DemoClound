using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Appharbor_SQL.Models;

namespace Appharbor_SQL.Controllers
{
    public class HocsinhsController : Controller
    {
        private db1a5b901da9be49abba78a6cc002d7f1aEntities db = new db1a5b901da9be49abba78a6cc002d7f1aEntities();

        // GET: Hocsinhs
        public async Task<ActionResult> Index()
        {
            return View(await db.Hocsinhs.ToListAsync());
        }

        // GET: Hocsinhs/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hocsinh hocsinh = await db.Hocsinhs.FindAsync(id);
            if (hocsinh == null)
            {
                return HttpNotFound();
            }
            return View(hocsinh);
        }

        // GET: Hocsinhs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hocsinhs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IDSinhVien,Ten,Email")] Hocsinh hocsinh)
        {
            if (ModelState.IsValid)
            {
                db.Hocsinhs.Add(hocsinh);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(hocsinh);
        }

        // GET: Hocsinhs/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hocsinh hocsinh = await db.Hocsinhs.FindAsync(id);
            if (hocsinh == null)
            {
                return HttpNotFound();
            }
            return View(hocsinh);
        }

        // POST: Hocsinhs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IDSinhVien,Ten,Email")] Hocsinh hocsinh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hocsinh).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(hocsinh);
        }

        // GET: Hocsinhs/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hocsinh hocsinh = await db.Hocsinhs.FindAsync(id);
            if (hocsinh == null)
            {
                return HttpNotFound();
            }
            return View(hocsinh);
        }

        // POST: Hocsinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            Hocsinh hocsinh = await db.Hocsinhs.FindAsync(id);
            db.Hocsinhs.Remove(hocsinh);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
