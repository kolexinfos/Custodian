using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Custodians.Models;
using PagedList;


namespace Custodians.Controllers
{
    public class CustodianController : Controller
    {
        //
        // GET: /Custodian/
        public ActionResult Index(string searchString, string currentFilter)
        {
            

            ViewBag.CurrentFilter = searchString;
            List<Custodian> model = new List<Custodian>();
            
            gssdb_cards context = new gssdb_cards();
           
            var data = context.DNN_Users
                        .OrderBy(r => r.FirstName)
                        .Where(r => searchString == null || (r.FirstName.Contains(searchString) || r.LastName.Contains(searchString) || r.Email.Contains(searchString)) )
                        .Take(100)
                        .Select(r => new Custodian{
                            Firstname = r.FirstName,
                            Lastname =r.LastName,
                            Email = r.Email,
                            ID = r.UserID
                        });

            return View(data);
        }

        //
        // GET: /Custodian/Details/5
        public ActionResult Details(int? id)
        {
            Custodian model = BuildCustodian(id);
            return View(model);
        }

        private static Custodian BuildCustodian(int? id)
        {
            Custodian model = new Custodian();
            using (gssdb_cards context = new gssdb_cards())
            {
                var user = from u in context.DNN_Users
                           where u.UserID == id
                           select new { firstname = u.FirstName, lastname = u.LastName, email = u.Email, id = u.UserID };


                foreach (var item in user)
                {
                    model.Email = item.email;
                    model.Firstname = item.firstname;
                    model.Lastname = item.lastname;
                    model.ID = item.id;
                    model.SOLID = model.GetSOLID(item.id);

                }
            }
            return model;
        }

        //
        // GET: /Custodian/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Custodian/Create
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

        //
        // GET: /Custodian/Edit/5
        public ActionResult Edit(int id)
        {

            Custodian model = BuildCustodian(id);
            return View(model);
        }

        //
        // POST: /Custodian/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    using (gssdb_cards context = new gssdb_cards())
                    {
                       // context.Entry()
                    }
                    return RedirectToAction("Index");
                }

                return View(BuildCustodian(id));
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Custodian/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Custodian/Delete/5
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
