using System;
using System.Collections.Generic;
using Blog.Models;

namespace Blog.Services
{
    public interface IArticleRespository
    {
        IEnumerable<Article> GetArticles();

        Article GetArticle(Guid articleId);
    }
}
