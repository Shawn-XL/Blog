using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ArticleController : Controller
    {
        private IArticleRepository _articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        [Route("/test")]
        public IActionResult Index()
        {
            return Ok("index action get called");
        }

        [HttpGet]
        public IActionResult GetArticles()
        {
            var articles = _articleRepository.GetArticles();
            return Ok(articles);
        }
        [HttpGet("{articleId}")]
        public IActionResult GetArticle(Guid articleId)
        {
            var articles = _articleRepository.GetArticle(articleId);
            return Ok(articles);
        }
    }
}
