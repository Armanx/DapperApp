using Data;
using DomeinCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MovieService
    {
        private Repository<Movie> MovieRepo { get; set; }
        private Repository<Genre> GenraRepo { get; set; }
        public MovieService()
        {
            MovieRepo = new Repository<Movie>();
            GenraRepo = new Repository<Genre>();
        }

        public void Add(Movie item)
        {
            item.Id = Guid.NewGuid();
            MovieRepo.Insert(item);
        }

        public List<Movie> GetAllMovies()
        {
            return MovieRepo.GetAll();
        }
    }
}
