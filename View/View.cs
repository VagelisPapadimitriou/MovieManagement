﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieManagement
{
    public class View
    {
        public static void Movies(List<Movie> movies, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-5}{"Title",-25}{"Country",-15}{"Rating",-10}{"Year",-10}{"Duration",-10}{"Price",-10}");
            Console.ResetColor();
            foreach (var movie in movies)
            {
                movie.Print();
            }
        }
        public static void Actors(List<Actor> actors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-5}{"FirstName",-15}{"LastName",-15}{"Country",-15}{"Birth",-10}{"Death",-10}{"Age",-10}{"Salary",-10}");
            Console.ResetColor();
            foreach (var actor in actors)
            {
                actor.Print();
            }
        }
        public static void Directors(List<Director> directors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-5}{"FirstName",-15}{"LastName",-15}{"Country",-15}{"Birth",-10}{"Death",-10}{"Age",-10}");
            Console.ResetColor();
            foreach (var director in directors)
            {
                director.Print();
            }
        }
        public static void Countries(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-5}{"Country",-25}");
            Console.ResetColor();
            string[] names = Enum.GetNames(typeof(Country));
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i,-5}{names[i],-25}");
            }
        }
        public static void MoviesPerDirector(List<Director> directors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"FirstName",-15}{"LastName",-15}{"Movies",-25}");
            Console.ResetColor();
            foreach (var director in directors)
            {
                director.PrintName();
                foreach (var movie in director.Movies)
                {
                    Console.Write($"{"",-30}");
                    movie.PrintTitle();
                }
            }
        }
        public static void DirectorsPerMovie(List<Movie> movies, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Movies",-25}{"FirstName",-15}{"LastName",-15}");
            Console.ResetColor();
            foreach (var movie in movies)
            {
                movie.PrintTitle();
                Console.Write($"{"",-25}");
                movie.Director.PrintName();

            }
        }
        public static void MoviesPerActor(List<Actor> actors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"FirstName",-15}{"LastName",-15}{"Movies",-25}");
            Console.ResetColor();
            foreach (var actor in actors)
            {
                actor.PrintName();
                foreach (var movie in actor.Movies)
                {
                    Console.Write($"{"",-30}");
                    movie.PrintTitle();
                }
            }
        }
        public static void ActorsPerMovie(List<Movie> movies, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Movies",-25}{"FirstName",-15}{"LastName",-15}");
            Console.ResetColor();
            foreach (var movie in movies)
            {
                movie.PrintTitle();
                foreach (var actor in movie.Actors)
                {
                    Console.Write($"{"",-25}");
                    actor.PrintName();
                }

            }
        }
        public static void ActorsPerCountry(List<Actor> actors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"FirstName",-15}{"LastName",-15}{"Country",-15}");
            Console.ResetColor();
            foreach (var actor in actors)
            {
                actor.PrintNameAndCountry();
            }
        }
        public static void FilterMoviesByTitle(List<Movie> movies, string message)
        {
            Console.WriteLine("Give Your Title");
            string criteria = Console.ReadLine();
            var filteredMovies = movies.Where(x => x.Title.Contains(criteria)).ToList();
            if (filteredMovies.Count == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no Movie in the Database containing '{criteria}'");
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                View.Movies(filteredMovies, message);
            }

        }
        public static void FilterActorsByFirstNameOrLastName(List<Actor> actors, string message)
        {
            Console.WriteLine("Give the FirstName");
            string criteriaFirstName = Console.ReadLine();

            Console.WriteLine("Give the LastName");
            string criteriaLastName = Console.ReadLine();


            var filteredActors = actors.Where(x => x.FirstName.Contains(criteriaFirstName)).ToList();
            filteredActors = filteredActors.Where(x => x.LastName.Contains(criteriaLastName)).ToList();

            if (filteredActors.Count == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no Actor in the Database containing '{criteriaFirstName}' - '{criteriaLastName}'");
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                View.Actors(filteredActors, message);
            }
        }
        public static void FilterDirectorsByFirstNameOrLastName(List<Director> directors, string message)
        {
            Console.WriteLine("Give the FirstName");
            string criteriaFirstName = Console.ReadLine();

            Console.WriteLine("Give the LastName");
            string criteriaLastName = Console.ReadLine();


            var filteredDirectors = directors.Where(x => x.FirstName.Contains(criteriaFirstName)).ToList();
            filteredDirectors = filteredDirectors.Where(x => x.LastName.Contains(criteriaLastName)).ToList();

            if (filteredDirectors.Count == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no Director in the Database containing '{criteriaFirstName}' - '{criteriaLastName}'");
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                View.Directors(filteredDirectors, message);
            }
        }
        public static void MoviesCount(List<Movie> movies, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Number of Movies: {movies.Count()}");
            Console.ResetColor();
        }
        public static void ActorsCount(List<Actor> actors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Number of Actors: {actors.Count()}");
            Console.ResetColor();
        }
        public static void DirectorsCount(List<Director> directors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Number of Directors: {directors.Count()}");
            Console.ResetColor();
        }
        public static void ActorsByCountry(List<Actor> actors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Yellow;

            var groupedResult = from actor in actors
                                group actor by actor.Country;

            foreach (var item in groupedResult)
            {
                Console.WriteLine($"{item.Key,20}: {item.Count()}");
            }
            Console.ResetColor();
        }
        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Choice - Error 404");
            Console.ResetColor();
        }
        public static void Menu()
        {
            const int first = -45;
            const int second = -45;
            const int third = -45;
            const int fourth = -50;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose an option");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine($"{"------------ ALL DATA ------------",first}{"------------ ORDERED BY ------------",second}{"------------ FILTER BY ------------",third}{"------------ STATS ------------",fourth}{"------------ E - EXIT ------------"}");
            Console.WriteLine($"{"1 - Movies",first}{"10 - Movies By Title",second}{"21 - Movies By Title",third}{"24 - Movies Count",fourth}");
            Console.WriteLine($"{"2 - Actors",first}{"11 - Movies By Rating",second}{"22 - Actors By FirstName or LastName",third}{"25 - Actors Count",fourth}");
            Console.WriteLine($"{"3 - Directors",first}{"12 - Movies By Price",second}{"23 - Directors By FirstName or LastName",third}{"26 - Directors Count",fourth}");
            Console.WriteLine($"{"4 - Countries",first}{"13 - Actors By FirstName",second}{"",third}{"27 - Actors By Country",fourth}");
            Console.WriteLine($"{"5 - Movies Per Director",first}{"14 - Actors By LastName",second}");
            Console.WriteLine($"{"6 - Directors Per Movie",first}{"15 - Actors By Salary",second}");
            Console.WriteLine($"{"7 - Movies Per Actor",first}{"16 - Actors By Year of Birth",second}");
            Console.WriteLine($"{"8 - Actors Per Movie",first}{"17 - Directors By FirstName",second}");
            Console.WriteLine($"{"9 - Actors Per Country",first}{"18 - Directors By LastName",second}");
            Console.WriteLine($"{"",first}{"19 - Directors By Age",second}");
            Console.WriteLine($"{"",first}{"20 - Directors By Year of Birth",second}");
        }
    }
}
