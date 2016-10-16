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
    public class OrderController : Controller
    {

        RestaurantContext db = new RestaurantContext();

        // GET: Order
        public ActionResult Order() 
        {
            //UserLIst
            UserOrderVM userListOrderVm= new UserOrderVM();
            var memberList = db.Users.ToList();
            userListOrderVm.UserOrderList = new SelectList(memberList, "Id", "Code");
            ViewBag.UserList = userListOrderVm.UserOrderList;

            //FoodList
            OrderFoodVM orderFood=new OrderFoodVM();
            var foodList = db.FoodItems.ToList();
            orderFood.FoodOrderList = new SelectList(foodList, "Id", "FoodName");
            ViewBag.FoodList = orderFood.FoodOrderList;

            return View();
        }

        //Post:Order
        [HttpPost]
        public ActionResult Order(OrderFood aOrder)
        {

            if (ModelState.IsValid)
            {
                db.OrderFoods.Add(aOrder);
                db.SaveChanges();
                ViewBag.Message = "Successfully Added.";
                return RedirectToAction("Index","Entry");

            }
            aOrder = null;
            return View();
        }



        //JSON Calling GetUserById
        public JsonResult GetUserById(int? id)
        {
            OrderFood aOrderFood = new OrderFood();
            User aUser = null;
            if (id != null)
            {
                aUser = db.Users.FirstOrDefault(c => c.Id == id);
                MemberType userType = null;
                userType = db.MemberTypes.FirstOrDefault(c => c.Id ==aUser.MemberTypeId);
                aOrderFood.Name =aUser.Name;
                aOrderFood.Email = aUser.Email;
                aOrderFood.ContactNo = aUser.ContactNo;
                aOrderFood.Type=userType.TypeName;

            }
            return Json(aOrderFood, JsonRequestBehavior.AllowGet);
        }
        
        //Json Result GetFoodById

        public JsonResult GetFoodById(int? id)
        {
            OrderFood aOrderFood1 = new OrderFood();
            FoodItem aFoodItem = null;
            if (id != null)
            {

                aFoodItem = db.FoodItems.FirstOrDefault(c => c.Id == id);
                aOrderFood1.UnitPrice = aFoodItem.UnitPrice;
            }
            return Json(aOrderFood1, JsonRequestBehavior.AllowGet);

        }

        //

    }
}