using System;
namespace Blog.Dtos
{
    public class ArticleDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
