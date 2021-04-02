using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Article
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength]
        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<ArticlePicture> ArticlePictures { get; set; }
            = new List<ArticlePicture>();

        public ICollection<Tag> ArticleTags { get; set; }
            = new List<Tag>();
    }
}
