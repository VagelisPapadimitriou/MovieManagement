using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDatabase db = new MyDatabase();
            const int first = -45;
            const int second = -45;
            const int third = -45;
            const int fourth = -50;
            string input;

            do
            {
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

                input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1": View.Movies(db.Movies, "All Movies"); break;
                    case "2": Console.WriteLine("I will do something else"); break;
                    default: Console.WriteLine("Wrong choice"); break;
                }


            } while (input != "E" && input != "e");



        }
    }

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
    }

}
