using System;
using System.Collections.Generic;

namespace Blog.Dtos
{
    public class ArticleDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string CreateDate { get; set; }

        public ICollection<ArticlePictureDto> ArticlePictures { get; set; }

    }
}
