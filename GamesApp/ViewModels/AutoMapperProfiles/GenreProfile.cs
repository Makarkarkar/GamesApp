using GamesApp.Models;
using AutoMapper;

namespace GamesApp.ViewModels.AutoMapperProfiles
{
    public class GenreProfile: Profile
    {
        public GenreProfile()
        {
            
            CreateMap<Genres, GenreViewModel>();
        }
    }
}