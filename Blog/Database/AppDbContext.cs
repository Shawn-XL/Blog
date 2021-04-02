using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var articleJson = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/Articles.json");
            IList<Article> articles = JsonConvert.DeserializeObject<IList<Article>>(articleJson);
            modelBuilder.Entity<Article>().HasData(articles);

            base.OnModelCreating(modelBuilder);
        }

    }
}
