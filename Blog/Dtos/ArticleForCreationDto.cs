using System;
using System.Collections.Generic;

namespace Blog.Dtos
{
    public class ArticleForCreationDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<ArticlePictureCreationDto> ArticlePictures { get; set; }
            = new List<ArticlePictureCreationDto>();
    }
}
