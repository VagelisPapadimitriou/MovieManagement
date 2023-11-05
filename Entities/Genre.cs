using System.Collections.Generic;

namespace MovieManagement
{
    public class Genre
    {
        public int GenreId { get; set; }

        public string Kind { get; set; }

        //Navigation Properties

        public List<Movie> Movies { get; set; }
    }

}
