using System;
namespace Blog.Dtos
{
    public class ArticlePictureDto
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string BaseSixFour { get; set; }

        public Guid ArticleId { get; set; }
    }
}
