using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public class ApplicationDbContext_DAL : DbContext
    {
        public ApplicationDbContext_DAL(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Appointments> Appointment2 { get; set; }
    }

    public class Appointments
    {
        public int Id { get; set; }
    }
}