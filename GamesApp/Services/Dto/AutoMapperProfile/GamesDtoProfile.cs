using AutoMapper;
using GamesApp.Models;

using GamesApp.Services.Dto;

namespace GamesApp.Services.Dto.AutoMapperProfile
{
    public class GamesDtoProfile:Profile
    {
        public GamesDtoProfile()
        {
            CreateMap<Games, GamesDto>().ReverseMap();
        }
    }
}