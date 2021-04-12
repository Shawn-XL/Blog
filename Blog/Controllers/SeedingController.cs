using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedingController : Controller
    {
        private IArticleRepository _articleRepository;
        private readonly IMapper _mapper;

        public SeedingController(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return Ok("Seeding Index action reached");
        }

        [Route("setdata")]
        [HttpGet]
        public IActionResult SetSeeding()
        {
            var restult = _articleRepository.SeedingData();
            if (restult)
            {
                return Ok("Seeding Data is Done");
            }
            else
            {
                return Ok("Something Wrong with Seeding Data");
            }
        }
        [Route("addpictures")]
        public IActionResult AddPic()
        {
            var restult = _articleRepository.AddPictures();
            if (restult)
            {
                return Ok("Succeed");
            }
            else
            {
                return Ok("Something Wrong");
            }
        }
        [Route("removedata")]
        [HttpGet]
        public IActionResult RemoveData()
        {
            var restult = _articleRepository.RemoveData();
            if (restult)
            {
                return Ok("Seeding Data is Removed");
            }
            else
            {
                return Ok("Something Wrong with Remove Data");
            }
        }
    }
}
