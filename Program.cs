﻿using BlogEntity.Data;
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

                //var user = new User
                //{
                //    Name = "Luizito",
                //    Email = "luizito@email.com",
                //    Slug = "luizi-to",
                //    Bio = "L.U.I.Z.I.T.O",
                //    Image = "https:",
                //    PasswordHash = "Hash",
                //};

                //var category = new Category
                //{
                //    Name = "Back-End",
                //    Slug = "backend",
                //};

                //var post = new Post
                //{
                //    Title = "Começando EF Core",
                //    Summary = "EF Core",
                //    Body = "EF Core dos crias",
                //    Slug = "ef-core",
                //    CreateDate = DateTime.Now,
                //    LastUpdateDate = DateTime.Now,
                //    Author = user,
                //    Category = category,
                //};

                //context.Posts.Add(post);
                //context.SaveChanges();

                //var posts = context.Posts
                //    .AsNoTracking()
                //    .Include(x => x.Author)
                //    .OrderByDescending(x => x.LastUpdateDate)
                //    .ToList();

                //foreach (var post in posts)
                //{
                //    Console.WriteLine($"{post.Title} | Autor: {post.Author?.Name}");
                //}

                var post = context.Posts
                    .Include(x => x.Category)
                    .Include(x => x.Author)
                    .Where(x => x.AuthorId == 6)
                    .FirstOrDefault();

                post.Author.Name = "Luizitito";
                context.Posts.Update(post);
                context.SaveChanges();
            }
        }
    }
}
