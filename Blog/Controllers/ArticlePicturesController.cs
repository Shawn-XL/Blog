using System;
using System.Collections.Generic;
using AutoMapper;
using Blog.Dtos;
using Blog.Models;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    [Route("api/article/{articleId}/pictures")]
    public class ArticlePicturesController : ControllerBase
    {
        private IArticleRepository _articleRepository;
        private IMapper _mapper;

        public ArticlePicturesController(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository ??
                throw new ArgumentNullException(nameof(articleRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetPictureListByArticleId(Guid articleId)
        {
            if(_articleRepository.ArticleExists(articleId))
            {
                return NotFound("Artcile Not Exist");
            }

            var picturesFromRepo = _articleRepository.GetPicturesByArticleId(articleId);
            if(picturesFromRepo == null || picturesFromRepo.Count < 0)
            {
                return NotFound("No Picture Found");
            }

            return Ok(_mapper.Map<List<ArticlePictureDto>>(picturesFromRepo));
        }
    }
}
