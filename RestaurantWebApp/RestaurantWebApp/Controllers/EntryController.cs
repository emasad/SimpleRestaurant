using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantWebApp.Context;
using RestaurantWebApp.Models;
using RestaurantWebApp.ViewModels;

namespace RestaurantWebApp.Controllers
{
    public class EntryController : Controller
    {
        //database
        RestaurantContext db = new RestaurantContext();
        // GET: Entry
        public ActionResult Index()
        {
            TypeListVm aTypeListVm=new TypeListVm();
            var memberTypes = db.MemberTypes.ToList();
            aTypeListVm.MemberTypes = new SelectList(memberTypes, "Id", "TypeName");
            return View(aTypeListVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Code,Name,Email,ContactNo,MemberTypeId")] TypeListVm aTypeListVm)
        {
            if (ModelState.IsValid)
            {
                User aUser= new User();
                aUser.Code = aTypeListVm.Code;
                aUser.Name = aTypeListVm.Name;
                aUser.Email = aTypeListVm.Email;
                aUser.ContactNo = aTypeListVm.ContactNo;
                aUser.MemberTypeId = aTypeListVm.MemberTypeId;

                db.Users.Add(aUser);
                db.SaveChanges();
                ViewBag.Message = "Successfully Added.";
                return RedirectToAction("Index","Home");

            }

            return View();
        }
    }
}