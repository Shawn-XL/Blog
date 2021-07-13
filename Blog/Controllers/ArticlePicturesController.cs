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
    [Route("api/articles/{articleId}/pictures")]
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
        [Route("")]
        public IActionResult GetPictureListByArticleId(Guid articleId)
        {
            if(!_articleRepository.ArticleExists(articleId))
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

        [HttpGet("{pictureId}", Name = "GetPicture")]
        public IActionResult GetPicture(Guid articleId, int pictureId)
        {
            if (!_articleRepository.ArticleExists(articleId))
            {
                return NotFound("Artcile Not Exist");
            }

            var pictureFromRepo = _articleRepository.GetPicture(pictureId);

            if(pictureFromRepo == null)
            {
                return NotFound("Picture Not Found");
            }
            return Ok(_mapper.Map<ArticlePictureDto>(pictureFromRepo));
        }

        [HttpPost]
        public IActionResult CreateArticlePicture(
            [FromRoute] Guid articleId,
            [FromBody] ArticlePictureCreationDto articlePictureCreationDto
            )
        {
            if (!_articleRepository.ArticleExists(articleId))
            {
                return NotFound("Artcile Not Exist");
            }

            var pictureModel = _mapper.Map<ArticlePicture>(articlePictureCreationDto);
            _articleRepository.AddArticlePicture(articleId, pictureModel);
            _articleRepository.Save();

            var pictureReturn = _mapper.Map<ArticlePictureDto>(pictureModel);
            return CreatedAtRoute(
                "GetPicture",
                new { articleId = pictureModel.ArticleId, pictureId = pictureModel.Id },
                pictureReturn
            );
        }
    }
}
