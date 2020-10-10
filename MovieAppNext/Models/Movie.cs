using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppNext.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public DateTime Year { get; set; }

        public string Actors { get; set; }

        public string Directors { get; set; }
    }
}
