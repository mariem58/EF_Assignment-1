using EF_Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Assignment.Context
{
    internal class CompanyDbContext:DbContext
    {
        //call it each time when create obj from context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BookStore;Integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<Book> books { get; set; }//table name= books
        public DbSet<Author> authors { get; set; }
        public DbSet<Category> categories { get; set; }//table name= books

    }
}
