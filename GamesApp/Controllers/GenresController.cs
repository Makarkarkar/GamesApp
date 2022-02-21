using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GamesApp.Data;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;


using GamesApp.Models;
using GamesApp.ViewModels;

namespace GamesApp.Controllers
{
    public class GenresController : Controller
    {
        private readonly GamesContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;

        public GenresController(GamesContext context, ILogger<HomeController> logger, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: Games
        [HttpGet]
        public IActionResult Genres()
        {
            var genre = _mapper.Map<IEnumerable<Genres>, IEnumerable<GenreViewModel>>(_context.Genres.ToList());
            return View(genre);
        }
    }
}