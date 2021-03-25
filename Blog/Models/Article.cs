using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public class Article
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<ArticlePicture> ArticlePictures { get; set; }
    }
}
