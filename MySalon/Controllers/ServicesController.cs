﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MySalon.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HairCut()
        {
            return View();
        }

        public IActionResult HairColorStyle()
        {
            return View();
        }

        public IActionResult Pedicure()
        {
            return View();
        }
    }
}