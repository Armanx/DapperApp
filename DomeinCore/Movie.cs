using System;
using System.Collections.Generic;
using System.Text;

namespace DomeinCore
{
    public class Movie : IDomainObject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public Genre Genre { get; set; }
        public List<Actor> Actors { get; set; }

    }
}
