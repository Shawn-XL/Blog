using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<ArticleTag> Articles { get; set; }
                = new List<ArticleTag>();
    }
}
