using System;
namespace Blog.Models
{
    public class ArticlePicture
    {
        public int Id { get; set; }

        public string? Url { get; set; }

        public string? BaseSixFour { get; set; }

        public Guid ArticleId { get; set; }

        public Article Article { get; set; }
    }
}
