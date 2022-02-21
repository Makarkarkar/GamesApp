using GamesApp.Models;
using AutoMapper;
using GamesApp.Services.Dto;

namespace GamesApp.ViewModels.AutoMapperProfiles
{
    public class GameProfile: Profile
    {
        public GameProfile()
        {
            
            CreateMap<GamesDto, GamesViewModel>();
        }
    }
}