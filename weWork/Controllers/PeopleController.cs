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
    public class PeopleController : Controller
    {
        private weWorkEntities context = new weWorkEntities();
        //
        // GET: /Person/

        public ViewResult Index()
        {
            return View(context.People.Include(person => person.PersonCompanies).Include(person => person.PersonGroups).Include(person => person.PersonProjects).ToList());
        }

        //
        // GET: /Person/Details/5

        public ViewResult Details(int id)
        {
            var person = context.People.Single(x => x.personId == id);
            return View(person);
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Person/Create

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                context.People.Add(person);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(person);
        }
        
        //
        // GET: /Person/Edit/5
 
        public ActionResult Edit(int id)
        {
            Person person = context.People.Single(x => x.personId == id);
            return View(person);
        }

        //
        // POST: /Person/Edit/5

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                context.Entry(person).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        //
        // GET: /Person/Delete/5
 
        public ActionResult Delete(int id)
        {
            Person person = context.People.Single(x => x.personId == id);
            return View(person);
        }

        //
        // POST: /Person/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = context.People.Single(x => x.personId == id);
            context.People.Remove(person);
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