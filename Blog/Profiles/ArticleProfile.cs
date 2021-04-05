using System;
using AutoMapper;
using Blog.Dtos;
using Blog.Models;

namespace Blog.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleDto>();
        }
    }
}
