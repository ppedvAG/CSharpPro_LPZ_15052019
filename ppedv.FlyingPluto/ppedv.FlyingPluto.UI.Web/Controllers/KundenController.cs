using ppedv.FlyingPluto.Logic;
using ppedv.FlyingPluto.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ppedv.FlyingPluto.UI.Web.Controllers
{
    public class KundenController : Controller
    {
        Core core;
        public KundenController()
        {
            var ass = Assembly.LoadFile(@"C:\Users\ar2\source\repos\ppedvAG\CSharpPro_LPZ_15052019\ppedv.FlyingPluto\ppedv.FlyingPluto.Data.EFdotnet\bin\Debug\ppedv.FlyingPluto.Data.EFdotnet.dll");

            var uow = ass.GetTypes().Where(x => x.GetInterfaces().Contains(typeof(IUnitOfWork))).FirstOrDefault();
            core = new Core((IUnitOfWork)Activator.CreateInstance(uow));

        }
        public async Task<ActionResult> Index()
        {
            return View(await core.UoW.KundenRepo.GetAllAsync());
        }

        // GET: Kunden/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kunden/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kunden/Create
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

        // GET: Kunden/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kunden/Edit/5
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

        // GET: Kunden/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kunden/Delete/5
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
    }
}
