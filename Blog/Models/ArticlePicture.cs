using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public class ArticlePicture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Url { get; set; }

        public string BaseSixFour { get; set; }

        [ForeignKey("ArticleId")]
        public Guid ArticleId { get; set; }

        public Article Article { get; set; }
    }
}
