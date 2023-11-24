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
        public DbSet<Category> Categories { get; set; }
    }
}
