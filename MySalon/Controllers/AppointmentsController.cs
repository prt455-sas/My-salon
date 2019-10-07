using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Internal.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MySalon_Master.Areas.Identity.Pages.Account;
using MySalon_Master.Data;
using MySalon_Master.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MySalon_Master.Models.ViewModel;


namespace MySalon_Master.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _signinuser;


        public AppointmentsController(ApplicationDbContext context, UserManager<ApplicationUser> user)
        {
            _context = context;
            _signinuser = user;
        }


        // GET: Appointments
        public IActionResult Index()
        {
            var userList = new ScheduleViewModel();
            if (User.Identity.IsAuthenticated)
            {
                //var LoggedinUser = _signinuser.GetUserId(HttpContext.User);
                //IdentityUser user = _signinuser.FindByIdAsync(LoggedinUser).Result;
                //var emailId = user.Email;
                //ViewBag.emailAddress = emailId;
                var useremail = User.Identity.Name;
                var lst = _context.Appointment.Where(a => a.UserId == useremail).ToList();
                return View(_context.Appointment.Where(a => a.UserId == useremail).ToList());
            }
            else
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
        }

        // GET: Appointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // GET: Appointments/Create
        public IActionResult Create()
        {
            var model = new Appointment();
            var LoggedinUser = _signinuser.GetUserId(HttpContext.User);
            IdentityUser user = _signinuser.FindByIdAsync(LoggedinUser).Result;
            var emailId = user.Email;
            ViewBag.email = emailId;
            var lstTimeRange = _context.TimeRanges.ToList();
            ViewBag.TimeRangeList = lstTimeRange;
            return View(model);
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BookedDate,BookTime,UserId,TimeRangeID")] Appointment appointment)
        {


            if (ModelState.IsValid)
            {
                appointment.BookTime = _context.TimeRanges.Find(appointment.TimeRangeID).Range;
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appointment);
        }

        // GET: Appointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointment.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return View(appointment);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BookedDate,BookedTime,UserId")] Appointment appointment)
        {
            if (id != appointment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointment.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(appointment);
        }

        // GET: Appointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appointment = await _context.Appointment.FindAsync(id);
            _context.Appointment.Remove(appointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentExists(int id)
        {
            return _context.Appointment.Any(e => e.Id == id);
        }
    }
}
