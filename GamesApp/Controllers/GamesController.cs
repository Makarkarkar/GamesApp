using System.Collections.Generic;
using AutoMapper;
using GamesApp.Data;
using GamesApp.Services;
using GamesApp.Services.Dto;
using GamesApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace GamesApp.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGamesService _service;
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;

        public GamesController(GamesContext context, ILogger<HomeController> logger, IMapper mapper, IGamesService service)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: Games
        [HttpGet]
        public IActionResult Games()
        {
            var game = _mapper.Map<IEnumerable<GamesDto>, IEnumerable<GamesViewModel>>(_service.GetAllGames());
            return View(game);
        }
    }
}