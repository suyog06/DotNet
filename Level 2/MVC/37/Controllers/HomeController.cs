﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _37.RadioButton.Models;

namespace _37.RadioButton.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Company company = new Company();
            return View(company);
        }

        [HttpPost]
        public string Index(Company company)
        {
            if (string.IsNullOrEmpty(company.SelectedDepartment))
            {
                return "You did not select any department";
            }
            else
            {
                return "You selected department with ID = " + company.SelectedDepartment;
            }
        }
    }
}