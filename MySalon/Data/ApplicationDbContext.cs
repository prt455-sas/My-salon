using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySalon_Master.Models;


namespace MySalon_Master.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ContactFormModel> ContactForms { get; set; }
        public DbSet<TimeRangeModel> TimeRanges { get; set; }
    }
}
