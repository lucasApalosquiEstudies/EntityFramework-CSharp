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

                // dotnet ef migrations script -o ./script.sql
            }
        }
    }
}
