using System;
namespace Blog.Models
{
    public class ArticleTag
    {
        public Guid ArticleId { get; set; }
        public Article Article { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
