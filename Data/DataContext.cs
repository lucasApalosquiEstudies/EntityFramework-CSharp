using BlogEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEntity.Data
{
    public class DataContext : DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-BVKU5HC;Database=FluentBlog;Trusted_Connection=True;TrustServerCertificate=True");
           
        }
    }
}
