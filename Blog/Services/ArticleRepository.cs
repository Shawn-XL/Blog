using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Blog.Database;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Blog.Services
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly AppDbContext _context;

        public ArticleRepository(AppDbContext context)
        {
            _context = context;
        }

        public Article GetArticle(Guid articleId)
        {
            return _context.Articles
                .Include(a => a.ArticlePictures)
                .FirstOrDefault(n => n.Id == articleId);
        }

        public IEnumerable<Article> GetArticles(string keyword)
        {
            IQueryable<Article> result = _context.Articles
                .Include(t => t.ArticlePictures);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.Trim();
                result = result.Where(t => t.Title.Contains(keyword));
            }

            return result.ToList();
        }

        public bool ArticleExists(Guid articleId)
        {
            return _context.Articles.Any(t => t.Id == articleId);
        }

        public List<ArticlePicture> GetPicturesByArticleId(Guid articleId)
        {
            return _context.ArticlePictures.Where(p => p.Article.Id == articleId).ToList();
        }

        public ICollection<Tag> GetTagsByArticleId(Guid articleId)
        {
            var result = _context.Articles
                .Where(p => p.Id == articleId)
                .Include(p => p.Tags)
                .Select(p => p.Tags)
                .FirstOrDefault();
            return result;
        }


        public ArticlePicture GetPicture(int pictureId)
        {
            return _context.ArticlePictures.Where(p => p.Id == pictureId).FirstOrDefault();
        }

        public void AddArticle(Article article)
        {
            if(article == null)
            {
                throw new ArgumentNullException(nameof(article));
            }

            _context.Articles.Add(article);
        }

        public void AddArticlePicture(Guid articleId, ArticlePicture articlePicture)
        {
            if (articleId == Guid.Empty)
            {
                throw new ArgumentNullException("Article Id");
            }

            if(articlePicture == null)
            {
                throw new ArgumentNullException(nameof(articlePicture));
            }
            articlePicture.ArticleId = articleId;
            _context.ArticlePictures.Add(articlePicture);
        }


        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        public bool SeedingData()
        {
            try
            {
                Console.WriteLine("Seeding Data begin");
                var articleJson = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/Articles.json");
                List<Article> articles = JsonConvert.DeserializeObject<List<Article>>(articleJson);
                _context.AddRange(articles);

                _context.AddRange(
                    new Tag()
                    {
                        ArticleTag = "c#",
                        Articles = articles
                    },
                    new Tag()
                    {
                        ArticleTag = "asp.net",
                        Articles = new List<Article>()
                        {
                        articles[2]
                        }
                    }
                );

                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            
        }

        public bool RemoveData()
        {
            try
            {
                _context.Articles.RemoveRange(_context.Articles.ToList());
                _context.ArticlePictures.RemoveRange(_context.ArticlePictures.ToList());
                _context.Tags.RemoveRange(_context.Tags.ToList());

                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

        }

        public bool AddPictures()
        {
            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    var articlePictureJson = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/ArticlePictures.json");
                    List<ArticlePicture> articlePictures = JsonConvert.DeserializeObject<List<ArticlePicture>>(articlePictureJson);
                    _context.AddRange(articlePictures);
                    _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.ArticlePictures ON;");
                    _context.SaveChanges();
                    _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.ArticlePictures OFF;");

                    transaction.Commit();
                }

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

        }
    }
}
