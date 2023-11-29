using BlogEntity.Data;
using BlogEntity.Models;
using Microsoft.EntityFrameworkCore;
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
                //context.Users.Add(new User
                //{
                //    Name = "Paozinho",
                //    Email = "Pao@email.com",
                //    Bio = "Pao de sal",
                //    Image = "https:",
                //    PasswordHash = "hash123",
                //    Slug = "paozinho"
                //});

                //var user = context.Users.First();


                //var post = new Post
                //{
                //    Title = "Receita de pão",
                //    Body = "Ovo, água e farinha",
                //    Summary = "Receitinha",
                //    Slug = "receita-pao",
                //    Category = new Category
                //    {
                //        Name = "Receita",
                //        Slug = "receita"
                //    },
                //    Author = user,

                //};

                

                var Tag = new Tag
                {
                    Name = "Reiceitas",
                    Slug = "receititasss"
                };

                var post = context.Posts
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Id == 3);

                //post.Tags.Add(Tag);
                //context.Posts.Add(post);
                context.Posts.Remove(post);

                context.SaveChanges();
               
            }
        }
    }
}
