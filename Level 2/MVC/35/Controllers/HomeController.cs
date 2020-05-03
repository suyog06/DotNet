using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _34.Models;

namespace _34.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SampleDBContext db = new SampleDBContext();
            List<SelectListItem> selectListItems = new List<SelectListItem>();

            foreach (Department department in db.Departments)
            {
                SelectListItem selectListItem = new SelectListItem
                {
                    Text = department.Name,
                    Value = department.Id.ToString(),
                    Selected = department.IsSelected.HasValue ? department.IsSelected.Value : false
                };
                selectListItems.Add(selectListItem);
            }

            ViewBag.Departments = selectListItems;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}