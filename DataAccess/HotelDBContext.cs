using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class HotelDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-PMQQUM0\\SQLEXPRESS; Database=HotelDB1; uid=sa;pwd=716519On*;");
        }

        public DbSet<Hotel> Hotels { get; set; }
       
    }
}
