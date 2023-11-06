using System;
using System.Linq;

namespace MovieManagement
{
    public class Application
    {
        public static void Run()
        {
            MyDatabase db = new MyDatabase();

            string input;

            do
            {
                View.Menu();

                input = Console.ReadLine();
                Console.Clear();

                Controller(db, input);

            } while (input != "E" && input != "e");
        }

        private static void Controller(MyDatabase db, string input)
        {
            switch (input)
            {
                case "1": View.Movies(db.Movies, "All Movies"); break;
                case "2": View.Actors(db.Actors, "All Actors"); break;
                case "3": View.Directors(db.Directors, "All Directors"); break;
                case "4": View.Countries("All Countries"); break;
                case "5": View.MoviesPerDirector(db.Directors, "All Movies Per Director"); break;
                case "6": View.DirectorsPerMovie(db.Movies, "All Directors Per Movie"); break;
                case "7": View.MoviesPerActor(db.Actors, "All Movies Per Actor"); break;
                case "8": View.ActorsPerMovie(db.Movies, "All Actors Per Movie"); break;
                case "9": View.ActorsPerCountry(db.Actors, "Actors Per Country"); break;
                case "10": View.Movies(db.Movies.OrderBy(x => x.Title).ToList(), "Movies Ordered By Title"); break;
                case "11": View.Movies(db.Movies.OrderBy(x => x.Rating).ToList(), "Movies Ordered By Rating"); break;
                case "12": View.Movies(db.Movies.OrderBy(x => x.Price).ToList(), "Movies Ordered By Price"); break;
                case "13": View.Actors(db.Actors.OrderBy(x => x.FirstName).ToList(), "Actors Ordered By First Name"); break;
                case "14": View.Actors(db.Actors.OrderBy(x => x.LastName).ToList(), "Actors Ordered By Last Name"); break;
                case "15": View.Actors(db.Actors.OrderBy(x => x.Salary).ToList(), "Actors Ordered By Salary"); break;
                case "16": View.Actors(db.Actors.OrderBy(x => x.DateOfBirth.Year).ToList(), "Actors Ordered By Birth"); break;
                case "17": View.Directors(db.Directors.OrderBy(x => x.FirstName).ToList(), "Directors Ordered By First Name"); break;
                case "18": View.Directors(db.Directors.OrderBy(x => x.LastName).ToList(), "Directors Ordered By Last Name"); break;
                case "19": View.Directors(db.Directors.OrderBy(x => x.Age).ToList(), "Directors Ordered By Age"); break;
                case "20": View.Directors(db.Directors.OrderBy(x => x.DateOfBirth.Year).ToList(), "Directors Ordered By Birth"); break;
                case "21": View.FilterMoviesByTitle(db.Movies, "Movies Filtered By Title"); break;
                case "22": View.FilterActorsByFirstNameOrLastName(db.Actors, "Actors Filtered By FirstName or LastName"); break;
                case "23": View.FilterDirectorsByFirstNameOrLastName(db.Directors, "Directors Filtered By FirstName or LastName"); break;
                case "24": View.MoviesCount(db.Movies, "Movies Count"); break;
                case "25": View.ActorsCount(db.Actors, "Actors Count"); break;
                case "26": View.DirectorsCount(db.Directors, "Directors Count"); break;
                case "27": View.ActorsByCountry(db.Actors, "Actors By Country"); break;
                default: View.Error(); break;
            }
        }

    }
}
