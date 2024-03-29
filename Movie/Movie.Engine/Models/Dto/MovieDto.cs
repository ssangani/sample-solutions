﻿using System;

namespace Movie.Engine.Models.Dto
{
    public class MovieDto
    {
        public long Id { get; set; }
        public string TitleName { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public TimeSpan RunningTime { get; set; }
        public string Genres { get; set; }
    }
}
