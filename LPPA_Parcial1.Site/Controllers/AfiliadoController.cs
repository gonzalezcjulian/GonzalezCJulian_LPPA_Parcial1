using LPPA_Parcial1.Site.Models;
using LPPA_Parcial1.Site.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LPPA_Parcial1.Site.Controllers
{
    public class AfiliadoController : Controller
    {
        private AfiliadoRepository _repo;
        public AfiliadoController()
        {
            _repo = new AfiliadoRepository();
        }

        // GET: Afiliado
        public ActionResult Index()
        {
            var model = _repo.ObtenerTodos();
            return View(model);
        }        

        // GET: Afiliado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Afiliado/Create
        [HttpPost]
        public ActionResult Create(Afiliado model)
        {
            try
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        _repo.Crear(model);
                        return RedirectToAction("Index");
                    }

                }
                catch (Exception ex)
                {

                }

                return View(model);
            }
            catch
            {
                return View();
            }
        }

        // GET: Afiliado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Afiliado/Edit/5
        [HttpPost]
        public ActionResult Edit(Afiliado model)
        {
            try
            {
                _repo.Editar(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Afiliado/Delete/5
        public ActionResult Delete(int id)
        {
            var db = new AfiliadoContext();
            var model = db.Afiliados.Find(id);
            return View(model);
        }

        // POST: Afiliado/Delete/5
        [HttpPost]
        public ActionResult Delete(Afiliado model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Eliminar(model);
                    return RedirectToAction("Index");
                }
            }
            catch(Exception ex)
            {
                
            }
            return View(model);
        }
    }
}
