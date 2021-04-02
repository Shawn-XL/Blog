using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleRepository _articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }


        [HttpGet]
        public IActionResult GetArticles()
        {
            var articlesFromRepo = _articleRepository.GetArticles();
            if(articlesFromRepo == null || articlesFromRepo.Count() < 0)
            {
                return NotFound("No Article Found");
            }
            return Ok(articlesFromRepo);
        }

        [HttpGet("{articleId}")]
        public IActionResult GetArticle(Guid articleId)
        {
            Article articleFromRepo = _articleRepository.GetArticle(articleId);
            if(articleFromRepo == null)
            {
                return NotFound("No Article Found");
            }
            
            return Ok(articleFromRepo);
        }
    }
}
