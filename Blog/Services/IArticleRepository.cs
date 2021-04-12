using System;
using System.Collections.Generic;
using Blog.Models;

namespace Blog.Services
{
    public interface IArticleRepository
    {
        IEnumerable<Article> GetArticles(string keyword);

        Article GetArticle(Guid articleId);

        bool ArticleExists(Guid articleId);

        List<ArticlePicture> GetPicturesByArticleId(Guid articleId);

        bool SeedingData();

        bool RemoveData();

        bool AddPictures();

        ICollection<Tag> GetTagsByArticleId(Guid articleId);
    }
}
