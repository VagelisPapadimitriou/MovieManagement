﻿using System;
using System.Collections.Generic;

namespace MovieManagement
{
    public class Actor
    {
        public int ActorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime? DateOfDeath { get; set; }

        public double Salary { get; set; }

        public int Age { get; set; }

        public Country Country { get; set; }

        //Navigation Properties

        public List<Movie> Movies { get; set; }
    }

}
