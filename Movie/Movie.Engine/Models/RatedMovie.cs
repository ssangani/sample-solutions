﻿using System.Collections.Generic;
using Movie.Engine.Models.Dto;

namespace Movie.Engine.Models
{
    public class RatedMovie
    {
        public MovieDto Movie { get; set; }
        public IEnumerable<RatingDto> Ratings { get; set; }
    }
}
