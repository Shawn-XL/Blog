using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Models;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    [ApiController]
    [Route("api/articles/{articleId}/tags")]
    public class ArticleTagsController : Controller
    {
        // GET: /<controller>/
        private IArticleRepository _articleRepository;
        private IMapper _mapper;

        public ArticleTagsController(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository ??
                throw new ArgumentNullException(nameof(articleRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetTagListByArticleId(Guid articleId)
        {
            if (!_articleRepository.ArticleExists(articleId))
            {
                return NotFound("Artcile Not Exist");
            }

            var tagsFromRepo = _articleRepository.GetTagsByArticleId(articleId);
            if (tagsFromRepo == null || tagsFromRepo.Count < 0)
            {
                return NotFound("No tag Found");
            }

            return Ok(_mapper.Map<List<Tag>>(tagsFromRepo));
        }
    }
}
