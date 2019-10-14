using System;
using System.Collections.Generic;
using System.Text;
using MySalon_Master.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace MySalon_Master.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ContactFormModel> ContactForms { get; set; }
        public DbSet<TimeRangeModel> TimeRanges { get; set; }
    }
}
