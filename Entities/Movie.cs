using System;
using System.Collections.Generic;

namespace MovieManagement
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string Title { get; set; }

        public double Rating { get; set; }

        public DateTime ProductionYear { get; set; }

        public int Duration { get; set; }

        public double? Price { get; set; }

        public Country Country { get; set; }

        //Navigation Properties

        public List<Actor> Actors { get; set; }

        public List<Genre> Genres { get; set; } = new List<Genre>();

        public Director Director { get; set; } = new Director();

    }

}
