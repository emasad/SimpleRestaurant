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
    public class ViewReportController : Controller
    {
        RestaurantContext db = new RestaurantContext();

        // GET: ViewReport
        public ActionResult Index()
        {
            //UserLIst
            UserOrderVM userListOrderVm = new UserOrderVM();
            var memberList = db.Users.ToList();
            userListOrderVm.UserOrderList = new SelectList(memberList, "Id", "Code");
            ViewBag.UserList = userListOrderVm.UserOrderList;
            return View();
        }

        //Get OrderInfo
        public JsonResult GetFoodOrderByUserDate(int? id, DateTime aDateTime)
        {
            double totalPrice = 0.0d;
            List<OrderFood> listFoodOrder = null;

            if (id != null)
            {

                listFoodOrder = db.OrderFoods.Where(c => c.CodeId == id && c.SelectedDate==aDateTime).ToList();
                totalPrice = listFoodOrder.Sum(x => (x.UnitPrice*x.Quantity));
            }
            return Json(new {Sum = totalPrice, OrderList = listFoodOrder}, JsonRequestBehavior.AllowGet);

        }

    }
}