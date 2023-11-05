using System;

namespace MovieManagement
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string Title { get; set; }

        public double Rating { get; set; }

        public DateTime dateTime { get; set; }

        public int Duration { get; set; }

        public double? Price { get; set; }
    }

}
