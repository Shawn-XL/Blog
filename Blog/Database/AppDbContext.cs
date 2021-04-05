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
            //Seed Data
            var articleJson = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/Articles.json");
            IList<Article> articles = JsonConvert.DeserializeObject<IList<Article>>(articleJson);
            modelBuilder.Entity<Article>().HasData(articles);

            //Many to Many: Tag and Article
            modelBuilder.Entity<ArticleTag>()
                .HasKey(t => new { t.ArticleId, t.TagId });

            modelBuilder
                .Entity<ArticleTag>()
                .HasOne(at => at.Article)
                .WithMany(a => a.Tags)
                .HasForeignKey(at => at.ArticleId);

            modelBuilder
                .Entity<ArticleTag>()
                .HasOne(at => at.Tag)
                .WithMany(a => a.Articles)
                .HasForeignKey(at => at.TagId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
