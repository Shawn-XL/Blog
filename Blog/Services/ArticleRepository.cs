using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Database;
using Blog.Models;

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
            return _context.Articles.FirstOrDefault(n => n.Id == articleId);
        }

        public IEnumerable<Article> GetArticles()
        {
            return _context.Articles;
        }
    }
}
