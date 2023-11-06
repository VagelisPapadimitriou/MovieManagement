using System;
using System.Collections.Generic;

namespace MovieManagement
{
    public class Director
    {
        public int DirectorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime? DateOfDeath { get; set; }

        public int Age
        {
            get
            {
                if (DateOfDeath.HasValue)
                {
                    return DateOfDeath.Value.Year - this.DateOfBirth.Year;
                }
                else
                {
                    return DateTime.Now.Year - this.DateOfBirth.Year;
                }
            }
        }

        public Country Country { get; set; }

        //Navigation Properties

        public List<Movie> Movies { get; set; }

        //Methods
        public void Print()
        {
            int? deathyear;
            if (!DateOfDeath.HasValue)
            {
                deathyear = null;
            }
            else
            {
                deathyear = DateOfDeath.Value.Year;
            }
            Console.WriteLine($"{DirectorId,-5}{FirstName,-15}{LastName,-15}{Country,-15}{DateOfBirth.Year,-10}{deathyear,-10}{Age,-10}");
        }

        public void PrintName()
        {
            Console.WriteLine($"{FirstName,-15}{LastName,-15}");
        }
    }

}
