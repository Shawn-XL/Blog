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

        ArticlePicture GetPicture(int pictureId);

        void AddArticle(Article article);

        void AddArticlePicture(Guid articleId, ArticlePicture articlePicture);

        bool Save();

        bool SeedingData();

        bool RemoveData();

        bool AddPictures();

        ICollection<Tag> GetTagsByArticleId(Guid articleId);
    }
}
