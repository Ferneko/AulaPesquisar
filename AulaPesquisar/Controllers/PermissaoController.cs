using AulaPesquisar.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaPesquisar.Controllers
{
    public class PermissaoController : Controller
    {
        private readonly Contexto db;

        public PermissaoController(Contexto db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            return View( db.permissao.ToList() ) ;
        }

        // GET: PermissaoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PermissaoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PermissaoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Permissao collection)
        {
            try
            {
                db.permissao.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PermissaoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PermissaoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PermissaoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PermissaoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
