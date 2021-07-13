using System;
using AutoMapper;
using Blog.Models;
using Blog.Dtos;

namespace Blog.Profiles
{
    public class ArticlePictureProfile : Profile
    {
        public ArticlePictureProfile()
        {
            CreateMap<ArticlePicture, ArticlePictureDto>();

            CreateMap<ArticlePictureCreationDto, ArticlePicture>();
        }
    }
}
