using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;

namespace Dot_Net_Mini_Project
{

    class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = VISHALMIL-VD\\SQL2017; Database = imsProject; user id=sa; password=cybage@123456;");
        }
        public DbSet<User> users { get; set; }
        public DbSet<Iphone> iphones { get; set; }
        public DbSet<Ipad> ipads { get; set; }
        public DbSet<Iwatch> iwatches { get; set; }
        public DbSet<Airpod> airpods { get; set; }
       
    }
}
