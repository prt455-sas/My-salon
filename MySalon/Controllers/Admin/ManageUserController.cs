﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySalon_Master.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySalon_Master.Controllers.Admin
{
    [Authorize(Roles = "Admin")]

    public class ManageUserController : Controller
    {

        private ApplicationDbContext _db;

        public ManageUserController(ApplicationDbContext db)
        {

            _db = db;
        }
        public async Task<IActionResult> UserManagement()
        {
            return View(await _db.Users.ToListAsync());
        }

        public async Task<IActionResult> UserInfo(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _db.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

    }
}
