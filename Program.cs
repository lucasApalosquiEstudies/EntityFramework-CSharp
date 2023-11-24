using BlogEntity.Data;
using BlogEntity.Models;
using System;

namespace BlogEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                var tag = new Tag { Name = "ASP.NET" , Slug = "aspnet"  };
                context.Tags.Add(tag);
                context.SaveChanges();

            }
        }
    }
}
