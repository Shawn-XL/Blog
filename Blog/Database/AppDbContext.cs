using System;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticlePicture> ArticlePictures { get; set; }

    }
}
