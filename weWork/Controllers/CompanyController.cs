using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeWorkModel;

namespace weWork.Controllers
{   
    public class CompanyController : Controller
    {
        private weWorkEntities context = new weWorkEntities();

        //
        // GET: /Company/

        public ViewResult Index()
        {
            return View(context.Companies.Include(company => company.CompanyCategories).Include(company => company.PersonCompanies).ToList());
        }

        //
        // GET: /Company/Details/5

        public ViewResult Details(int id)
        {
            Company company = context.Companies.Single(x => x.companyId == id);
            return View(company);
        }

        //
        // GET: /Company/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Company/Create

        [HttpPost]
        public ActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                context.Companies.Add(company);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(company);
        }
        
        //
        // GET: /Company/Edit/5
 
        public ActionResult Edit(int id)
        {
            Company company = context.Companies.Single(x => x.companyId == id);
            return View(company);
        }

        //
        // POST: /Company/Edit/5

        [HttpPost]
        public ActionResult Edit(Company company)
        {
            if (ModelState.IsValid)
            {
                context.Entry(company).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(company);
        }

        //
        // GET: /Company/Delete/5
 
        public ActionResult Delete(int id)
        {
            Company company = context.Companies.Single(x => x.companyId == id);
            return View(company);
        }

        //
        // POST: /Company/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Company company = context.Companies.Single(x => x.companyId == id);
            context.Companies.Remove(company);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}