using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using catologoEm3.Models;

namespace catologoEm3.Controllers
{
    public class CarroController : Controller
    {
        private readonly catalogoOficialEntities db = new catalogoOficialEntities();

        // GET: Carro
        public ActionResult Index()
        {
            var carro = db.Carro.Include(c => c.Cliente1).Include(c => c.Tipo1);
            return View(carro.ToList());
        }

        // GET: Carro/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carro carro = db.Carro.Find(id);
            if (carro == null)
            {
                return HttpNotFound();
            }
            return View(carro);
        }

        // GET: Carro/Create
        public ActionResult Create()
        {
            ViewBag.cliente = new SelectList(db.Cliente, "id_Cliente", "CPF");
            ViewBag.tipo = new SelectList(db.Tipo, "id_Tipo", "descricao");
            return View();
        }

        // POST: Carro/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_carro,nome_Carro,cor_Carro,cliente,tipo")] Carro carro)
        {
            if (ModelState.IsValid)
            {
                db.Carro.Add(carro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cliente = new SelectList(db.Cliente, "id_Cliente", "CPF", carro.cliente);
            ViewBag.tipo = new SelectList(db.Tipo, "id_Tipo", "descricao", carro.tipo);
            return View(carro);
        }

        // GET: Carro/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carro carro = db.Carro.Find(id);
            if (carro == null)
            {
                return HttpNotFound();
            }
            ViewBag.cliente = new SelectList(db.Cliente, "id_Cliente", "CPF", carro.cliente);
            ViewBag.tipo = new SelectList(db.Tipo, "id_Tipo", "descricao", carro.tipo);
            return View(carro);
        }

        // POST: Carro/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_carro,nome_Carro,cor_Carro,cliente,tipo")] Carro carro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cliente = new SelectList(db.Cliente, "id_Cliente", "CPF", carro.cliente);
            ViewBag.tipo = new SelectList(db.Tipo, "id_Tipo", "descricao", carro.tipo);
            return View(carro);
        }

        // GET: Carro/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carro carro = db.Carro.Find(id);
            if (carro == null)
            {
                return HttpNotFound();
            }
            return View(carro);
        }

        // POST: Carro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Carro carro = db.Carro.Find(id);
            db.Carro.Remove(carro);
            db.SaveChanges();
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
