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
            CreateMap<Article, ArticleDto>()
                .ForMember(
                    dest => dest.CreateDate,
                    opt => opt.MapFrom(src => src.CreateDate.ToString("yyyy MMMM dd")
                ));

            CreateMap<ArticleForCreationDto, Article>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => Guid.NewGuid())
                )
                .ForMember(
                    dest => dest.CreateDate,
                    opt => opt.MapFrom(src => DateTime.Now)
                );
        }
    }
}
