using P21.Entity.Services;
using P21.Extensions.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P21.Rules.Visual.Controllers
{
    public class DefaultController : BaseRuleController
    {
        private BusinessRuleService service = new BusinessRuleService();
        // GET: Default
        public ActionResult Index()
        {
            var result = service.GetAllRules();
            return View(result);
        }

        // GET: Default/Details/5
        public ActionResult Details()
        {
            return View(Rule);
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View(Rule);
        }

        // POST: Default/Create
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

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
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

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
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
