using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Dtos;
using Blog.Models;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private IArticleRepository _articleRepository;
        private readonly IMapper _mapper;

        public ArticlesController(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetArticles([FromQuery]string keyword)
        {
            var articlesFromRepo = _articleRepository.GetArticles(keyword);
            if(articlesFromRepo == null || articlesFromRepo.Count() < 0)
            {
                return NotFound("No Article Found");
            }
            var articles = _mapper.Map<IEnumerable<ArticleDto>>(articlesFromRepo);
            return Ok(articles);
        }

        [HttpGet("{articleId}", Name = "GetArticle")]
        public IActionResult GetArticle(Guid articleId)
        {
            Article articleFromRepo = _articleRepository.GetArticle(articleId);
            if(articleFromRepo == null)
            {
                return NotFound("No Article Found");
            }

            var articleDto = _mapper.Map<ArticleDto>(articleFromRepo);
            return Ok(articleDto);
        }

        [HttpPost]
        public IActionResult CreateArticle([FromBody] ArticleForCreationDto articleForCreationDto)
        {
            var articleModel = _mapper.Map<Article>(articleForCreationDto);

            _articleRepository.AddArticle(articleModel);
            _articleRepository.Save();

            var articleReturn = _mapper.Map<ArticleDto>(articleModel);

            return CreatedAtRoute(
                "GetArticle",
                new { articleId = articleReturn.Id },
                articleReturn
                );
        }
    }
}
