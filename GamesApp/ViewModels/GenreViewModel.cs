using System;
using System.Collections.Generic;
using GamesApp.Models;

namespace GamesApp.ViewModels
{
    public class GenreViewModel
    {
        public GenreViewModel()
        {
            Games = new HashSet<Models.Games>();
        }
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public IEnumerable<Models.Games> Games { get; set; }
    }
}