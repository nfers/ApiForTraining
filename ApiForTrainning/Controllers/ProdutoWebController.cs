using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiForTraining.Domain.Entidades;
using ApiTraining.Aplicacao.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiForTrainningWeb.Controllers
{
    public class ProdutoWebController : Controller
    {
        private readonly InterfaceProdutoApp ProdutoApp;

        public ProdutoWebController(InterfaceProdutoApp _ProdutoApp)
        {
            ProdutoApp = _ProdutoApp;
        }

        // GET: ProdutoWeb
        public ActionResult Index()
        {
            return View(ProdutoApp.Listar());
        }

        // GET: ProdutoWeb/Details/5
        public ActionResult Details(int id)
        {
            return View(ProdutoApp.ObterPorId(id));
        }

        // GET: ProdutoWeb/Create
        public ActionResult Create()
        {
            return View( new Produto());
        }

        // POST: ProdutoWeb/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoWeb/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutoWeb/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoWeb/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdutoWeb/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}