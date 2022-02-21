using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using GamesApp.Data;
using GamesApp.Models;
using GamesApp.ViewModels;
using GamesApp.Services.Dto;

namespace GamesApp.Services
{
    public class GenreService:IGenreService
    {
        private readonly GamesContext _context;
        private readonly IMapper _mapper;
        
        public GenreService(GamesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public GenreDto GetGenre(int id)
        {
            var genre =  _mapper.Map<GenreDto>(_context.Genres.FirstOrDefault(m => m.GenreId == id));
            if (genre == null) return null;
            genre.Games = _context.GamesGenres.Where(ge => ge.GenreId == genre.GenreId).Select(ge => ge.Games).ToList();
            // genre.AllGames = _context.Games.ToList();
            return genre;
        }

        public IEnumerable<GenreDto> GetAllGenres()
        {
            var genres =  _mapper.Map<IEnumerable<Genres>, IEnumerable<GenreDto>>(_context.Genres.ToList()).ToList();
            foreach (var genre in genres)
            {
                genre.Games = _context.GamesGenres.Where(ge => ge.GenreId == genre.GenreId).Select(ge => ge.Games).ToList();
            }
            
            return genres;
        }

        
    }
}