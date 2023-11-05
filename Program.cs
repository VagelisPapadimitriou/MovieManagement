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

        }
    }

    public class MyDatabase
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public List<Director> Directors { get; set; } = new List<Director>();

        public List<Actor> Actors { get; set; } = new List<Actor>();

        public List<Genre> Genres { get; set; } = new List<Genre>();

        public MyDatabase()
        {
            #region Seeding Movies
            //================== Seeding Movies ==================
            Movie m1 = new Movie()
            {
                MovieId = 1,
                Title = "The Matrix",
                Duration = 136,
                Price = 9.8,
                ProductionYear = new DateTime(1999, 3, 24),
                Rating = 8.7D,
                Country = Country.Australia
            };
            Movie m2 = new Movie()
            {
                MovieId = 2,
                Title = "Little Nicky",
                Duration = 90,
                Price = 3.8,
                ProductionYear = new DateTime(2000, 11, 2),
                Rating = 5.3D,
                Country = Country.USA
            };
            Movie m3 = new Movie()
            {
                MovieId = 3,
                Title = "The Rock",
                Duration = 135,
                Price = 4.5,
                ProductionYear = new DateTime(1996, 6, 3),
                Rating = 7.4D,
                Country = Country.USA
            };
            Movie m4 = new Movie()
            {
                MovieId = 4,
                Title = "Inception",
                Duration = 148,
                Price = 7.5,
                ProductionYear = new DateTime(2010, 7, 8),
                Rating = 8.8D,
                Country = Country.England
            };
            Movie m5 = new Movie()
            {
                MovieId = 5,
                Title = "Time Trap",
                Duration = 87,
                Price = 5.3,
                ProductionYear = new DateTime(2017, 10, 28),
                Rating = 6.2D,
                Country = Country.Belarus
            };
            Movie m6 = new Movie()
            {
                MovieId = 6,
                Title = "The Lego Movie",
                Duration = 100,
                Price = 6.2,
                ProductionYear = new DateTime(2014, 2, 1),
                Rating = 7.7D,
                Country = Country.Italy
            };
            Movie m7 = new Movie()
            {
                MovieId = 7,
                Title = "Time Lapse",
                Duration = 104,
                Price = 6.5,
                ProductionYear = new DateTime(2014, 4, 19),
                Rating = 6.5D,
                Country = Country.Belarus
            };
            Movie m8 = new Movie()
            {
                MovieId = 8,
                Title = "Click",
                Duration = 107,
                Price = 5.5,
                ProductionYear = new DateTime(2006, 6, 14),
                Rating = 6.4D,
                Country = Country.Australia
            };
            Movie m9 = new Movie()
            {
                MovieId = 9,
                Title = "Face/Off",
                Duration = 138,
                Price = 7.1,
                ProductionYear = new DateTime(1997, 6, 19),
                Rating = 7.3D,
                Country = Country.USA
            };
            Movie m10 = new Movie()
            {
                MovieId = 10,
                Title = "Men in Black",
                Duration = 98,
                Price = 7.7,
                ProductionYear = new DateTime(1997, 6, 25),
                Rating = 7.3D,
                Country = Country.USA
            };
            #endregion

            #region Seeding Actors
            //================== Seeding Actors ==================
            Actor a1 = new Actor()
            {
                ActorId = 1,
                FirstName = "Keanu",
                LastName = "Reeves",
                DateOfBirth = new DateTime(1964, 9, 2),
                DateOfDeath = null,
                Salary = 500000,
                Country = Country.Madagascar
            };
            a1.Movies = new List<Movie>() { m1, m6, m7 };
            m1.Actors.Add(a1);
            m6.Actors.Add(a1);
            m7.Actors.Add(a1);

            Actor a2 = new Actor()
            {
                ActorId = 2,
                FirstName = "Carrie-Anne",
                LastName = "Moss",
                DateOfBirth = new DateTime(1967, 8, 21),
                DateOfDeath = null,
                Salary = 350000,
                Country = Country.Australia
            };
            a2.Movies = new List<Movie>() { m1 };
            m1.Actors.Add(a2);

            Actor a3 = new Actor()
            {
                ActorId = 3,
                FirstName = "Adam",
                LastName = "Sandler",
                DateOfBirth = new DateTime(1966, 9, 9),
                DateOfDeath = null,
                Salary = 700000,
                Country = Country.USA
            };
            a3.Movies = new List<Movie>() { m2, m8 };
            m2.Actors.Add(a3);
            m8.Actors.Add(a3);

            Actor a4 = new Actor()
            {
                ActorId = 4,
                FirstName = "Rodney",
                LastName = "Dangerfield",
                DateOfBirth = new DateTime(1921, 11, 22),
                DateOfDeath = new DateTime(2004, 10, 5),
                Salary = 550000,
                Country = Country.USA
            };
            a4.Movies = new List<Movie>() { m2 };
            m2.Actors.Add(a4);

            Actor a5 = new Actor()
            {
                ActorId = 5,
                FirstName = "Nicolas ",
                LastName = "Cage",
                DateOfBirth = new DateTime(1964, 1, 7),
                DateOfDeath = null,
                Salary = 650000,
                Country = Country.Italy
            };
            a5.Movies = new List<Movie>() { m3, m9 };
            m3.Actors.Add(a5);
            m9.Actors.Add(a5);

            Actor a6 = new Actor()
            {
                ActorId = 6,
                FirstName = "Sean",
                LastName = "Connery",
                DateOfBirth = new DateTime(1930, 8, 25),
                DateOfDeath = new DateTime(2020, 10, 31),
                Salary = 800000,
                Country = Country.England
            };
            a6.Movies = new List<Movie>() { m3 };
            m3.Actors.Add(a6);

            Actor a7 = new Actor()
            {
                ActorId = 7,
                FirstName = "Leonardo",
                LastName = "DiCaprio",
                DateOfBirth = new DateTime(1974, 11, 11),
                DateOfDeath = null,
                Salary = 750000,
                Country = Country.USA
            };
            a7.Movies = new List<Movie>() { m4 };
            m4.Actors.Add(a7);

            Actor a8 = new Actor()
            {
                ActorId = 8,
                FirstName = "Tom",
                LastName = "Hardy",
                DateOfBirth = new DateTime(1977, 9, 15),
                DateOfDeath = null,
                Salary = 450000,
                Country = Country.England
            };
            a8.Movies = new List<Movie>() { m4 };
            m4.Actors.Add(a8);

            Actor a9 = new Actor()
            {
                ActorId = 9,
                FirstName = "Andrew",
                LastName = "Wilson",
                DateOfBirth = new DateTime(1964, 8, 22),
                DateOfDeath = null,
                Salary = 350000,
                Country = Country.USA
            };
            a9.Movies = new List<Movie>() { m5 };
            m5.Actors.Add(a9);

            Actor a10 = new Actor()
            {
                ActorId = 10,
                FirstName = "Reiley",
                LastName = "McClendon",
                DateOfBirth = new DateTime(1990, 3, 11),
                DateOfDeath = null,
                Salary = 250000,
                Country = Country.USA
            };
            a10.Movies = new List<Movie>() { m5 };
            m5.Actors.Add(a10);

            Actor a11 = new Actor()
            {
                ActorId = 11,
                FirstName = "Chris",
                LastName = "Pratt",
                DateOfBirth = new DateTime(1979, 6, 21),
                DateOfDeath = null,
                Salary = 650000,
                Country = Country.USA
            };
            a11.Movies = new List<Movie>() { m6 };
            m6.Actors.Add(a11);

            Actor a12 = new Actor()
            {
                ActorId = 12,
                FirstName = "Will",
                LastName = "Ferrell",
                DateOfBirth = new DateTime(1967, 7, 16),
                DateOfDeath = null,
                Salary = 680000,
                Country = Country.USA
            };
            a12.Movies = new List<Movie>() { m6 };
            m6.Actors.Add(a12);

            Actor a13 = new Actor()
            {
                ActorId = 13,
                FirstName = "Danielle",
                LastName = "Panabaker",
                DateOfBirth = new DateTime(1987, 9, 19),
                DateOfDeath = null,
                Salary = 380000,
                Country = Country.USA
            };
            a13.Movies = new List<Movie>() { m7 };
            m7.Actors.Add(a13);

            Actor a14 = new Actor()
            {
                ActorId = 14,
                FirstName = "Matt",
                LastName = "O'Leary",
                DateOfBirth = new DateTime(1987, 7, 6),
                DateOfDeath = null,
                Salary = 340000,
                Country = Country.USA
            };
            a14.Movies = new List<Movie>() { m7 };
            m7.Actors.Add(a14);

            Actor a15 = new Actor()
            {
                ActorId = 15,
                FirstName = "Christopher",
                LastName = "Walken",
                DateOfBirth = new DateTime(1943, 3, 31),
                DateOfDeath = null,
                Salary = 840000,
                Country = Country.USA
            };
            a15.Movies = new List<Movie>() { m8 };
            m8.Actors.Add(a15);

            Actor a16 = new Actor()
            {
                ActorId = 16,
                FirstName = "David",
                LastName = "Hasselhoff",
                DateOfBirth = new DateTime(1952, 7, 17),
                DateOfDeath = null,
                Salary = 840000,
                Country = Country.USA
            };
            a16.Movies = new List<Movie>() { m8 };
            m8.Actors.Add(a16);

            Actor a17 = new Actor()
            {
                ActorId = 17,
                FirstName = "John",
                LastName = "Travolta",
                DateOfBirth = new DateTime(1954, 2, 18),
                DateOfDeath = null,
                Salary = 770000,
                Country = Country.USA
            };
            a17.Movies = new List<Movie>() { m9 };
            m9.Actors.Add(a17);

            Actor a18 = new Actor()
            {
                ActorId = 18,
                FirstName = "Alessandro",
                LastName = "Nivola",
                DateOfBirth = new DateTime(1972, 6, 28),
                DateOfDeath = null,
                Salary = 690000,
                Country = Country.Italy
            };
            a18.Movies = new List<Movie>() { m9 };
            m9.Actors.Add(a18);

            Actor a19 = new Actor()
            {
                ActorId = 19,
                FirstName = "Tommy Lee",
                LastName = "Jones",
                DateOfBirth = new DateTime(1946, 9, 15),
                DateOfDeath = null,
                Salary = 790000,
                Country = Country.USA
            };
            a19.Movies = new List<Movie>() { m10 };
            m10.Actors.Add(a19);

            Actor a20 = new Actor()
            {
                ActorId = 19,
                FirstName = "Will",
                LastName = "Smith",
                DateOfBirth = new DateTime(1968, 9, 25),
                DateOfDeath = null,
                Salary = 830000,
                Country = Country.USA
            };
            a20.Movies = new List<Movie>() { m10 };
            m10.Actors.Add(a20);
            #endregion

            #region Seeding Directors
            //================== Seeding Directors ==================
            Director d1 = new Director()
            {
                DirectorId = 1,
                FirstName = "Lana",
                LastName = "Wachowski",
                DateOfBirth = new DateTime(1965, 6, 21),
                DateOfDeath = null,
                Country = Country.USA
            };
            d1.Movies = new List<Movie>() { m1 };
            m1.Director = d1;

            Director d2 = new Director()
            {
                DirectorId = 2,
                FirstName = "Steven",
                LastName = "Brill",
                DateOfBirth = new DateTime(1967, 12, 29),
                DateOfDeath = null,
                Country = Country.USA
            };
            d2.Movies = new List<Movie>() { m2, m7 };
            m2.Director = d2;
            m7.Director = d2;

            Director d3 = new Director()
            {
                DirectorId = 3,
                FirstName = "Michael",
                LastName = "Bay",
                DateOfBirth = new DateTime(1965, 2, 17),
                DateOfDeath = null,
                Country = Country.USA
            };
            d3.Movies = new List<Movie>() { m3, m5, m10 };
            m3.Director = d3;
            m5.Director = d3;
            m10.Director = d3;

            Director d4 = new Director()
            {
                DirectorId = 4,
                FirstName = "Christopher",
                LastName = "Nolan",
                DateOfBirth = new DateTime(1970, 7, 30),
                DateOfDeath = null,
                Country = Country.England
            };
            d4.Movies = new List<Movie>() { m4, m6 };
            m4.Director = d4;
            m6.Director = d4;

            Director d5 = new Director()
            {
                DirectorId = 5,
                FirstName = "Frank",
                LastName = "Coraci",
                DateOfBirth = new DateTime(1966, 2, 3),
                DateOfDeath = null,
                Country = Country.Italy
            };
            d5.Movies = new List<Movie>() { m8 };
            m8.Director = d5;

            Director d6 = new Director()
            {
                DirectorId = 6,
                FirstName = "John",
                LastName = "Woo",
                DateOfBirth = new DateTime(1946, 9, 22),
                DateOfDeath = null,
                Country = Country.China
            };
            d6.Movies = new List<Movie>() { m9 };
            m9.Director = d6;
            #endregion

            #region Seeding Genres
            //================== Seeding Genres ==================
            Genre g1 = new Genre() { Kind = "Action" };
            Genre g2 = new Genre() { Kind = "Adventure" };
            Genre g3 = new Genre() { Kind = "Comedy" };
            Genre g4 = new Genre() { Kind = "Crime" };
            Genre g5 = new Genre() { Kind = "Drama" };
            Genre g6 = new Genre() { Kind = "Fantasy" };
            Genre g7 = new Genre() { Kind = "Horror" };
            Genre g8 = new Genre() { Kind = "Mystery" };
            Genre g9 = new Genre() { Kind = "Sci-Fi" };
            Genre g10 = new Genre() { Kind = "Thriller" };
            #endregion

            #region Add Movies to Genres
            //================== Add Movies to Genres ==================
            g1.Movies = new List<Movie>() { m1, m3, m4, m5, m6, m9, m10 }; //Action
            g2.Movies = new List<Movie>() { m3, m4, m5, m6, m10 };         //Adventure
            g3.Movies = new List<Movie>() { m2, m8, m10 };                 //Comedy
            g4.Movies = new List<Movie>() { m9 };                          //Crime
            g5.Movies = new List<Movie>() { m8 };                          //Drama
            g6.Movies = new List<Movie>() { m2, m8 };                      //Fantasy
            g7.Movies = new List<Movie>() { m7 };                          //Horror
            g8.Movies = new List<Movie>() { m5, m7 };                      //Mystery
            g9.Movies = new List<Movie>() { m1, m4, m7, m9 };              //Sci-Fi
            g10.Movies = new List<Movie>() { m3 };                         //Thriller
            #endregion

            #region Add Genres to Movies
            //================== Add Genres to Movies ==================
            m1.Genres.Add(g1);
            m1.Genres.Add(g9);
            m2.Genres.Add(g3);
            m2.Genres.Add(g6);
            m3.Genres.Add(g1);
            m3.Genres.Add(g2);
            m3.Genres.Add(g10);
            m4.Genres.Add(g1);
            m4.Genres.Add(g2);
            m4.Genres.Add(g9);
            m5.Genres.Add(g1);
            m5.Genres.Add(g2);
            m5.Genres.Add(g8);
            m6.Genres.Add(g1);
            m6.Genres.Add(g2);
            m7.Genres.Add(g7);
            m7.Genres.Add(g8);
            m7.Genres.Add(g9);
            m8.Genres.Add(g3);
            m8.Genres.Add(g5);
            m8.Genres.Add(g6);
            m9.Genres.Add(g1);
            m9.Genres.Add(g4);
            m9.Genres.Add(g9);
            m10.Genres.Add(g1);
            m10.Genres.Add(g2);
            m10.Genres.Add(g3);
            #endregion

            #region PopulateLists
            List<Movie> movies = new List<Movie>() { m1, m2, m3, m4, m5, m6, m7, m8, m9, m10 };
            Movies.AddRange(movies);

            List<Actor> actors = new List<Actor>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a14, a15, a16, a17, a18, a19, a20 };
            Actors.AddRange(actors);

            List<Director> directors = new List<Director>() { d1, d2, d3, d4, d5, d6 };
            Directors.AddRange(directors);

            List<Genre> genres = new List<Genre>() { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 };
            Genres.AddRange(genres);
            #endregion
        }



    }

}
