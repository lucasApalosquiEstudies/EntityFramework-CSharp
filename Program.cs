using BlogEntity.Data;
using BlogEntity.Models;
using System;
using System.Linq;

namespace BlogEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                //var tag = new Tag { Name = "Python" , Slug = "PyCharm"  };
                //context.Tags.Add(tag);
                //context.SaveChanges();

                //var tag = context.Tags.FirstOrDefault(x => x.Id == 6);
                //tag.Name = "ASP.NETCore";
                //context.Tags.Update(tag);
                //context.SaveChanges();

                //var tag = context.Tags.FirstOrDefault(x => x.Id == 7);
                //context.Tags.Remove(tag);
                //context.SaveChanges();

                var tags = context.Tags.ToList();

                foreach (var tag in tags)
                {
                    Console.WriteLine($"Tag Name: {tag.Name} Slug: {tag.Slug}");
                }



            }
        }
    }
}
