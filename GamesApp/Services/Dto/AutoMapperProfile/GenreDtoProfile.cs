using AutoMapper;
using GamesApp.Models;

using GamesApp.Services.Dto;

namespace GamesApp.Services.Dto.AutoMapperProfile
{
    public class GenreDtoProfile:Profile
    {
        public GenreDtoProfile()
        {
            CreateMap<Genres, GenreDto>().ReverseMap();
        }
    }
}