﻿using System;
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

        public List<Actor> Actors { get; set; } = new List<Actor>();

        public List<Genre> Genres { get; set; } = new List<Genre>();

        public Director Director { get; set; } = new Director();

        //Methods
        public void Print()
        {
            Console.WriteLine($"{MovieId,-5}{Title,-25}{Country,-15}{Rating,-10}{ProductionYear.Year,-10}{Duration,-10}{Price,-10}");
        }

        public void PrintTitle()
        {
            Console.WriteLine($"{Title,-25}");
        }

    }

}
