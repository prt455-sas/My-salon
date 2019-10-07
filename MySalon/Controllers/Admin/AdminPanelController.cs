using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySalon_Master.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySalon_Master.Controllers.Admin
{
    [Authorize(Roles = "Admin")]
    public class AdminPanelController : Controller
    {

        private ApplicationDbContext _db;

        public AdminPanelController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
    }
}
