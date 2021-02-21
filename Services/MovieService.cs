using Data;
using DomeinCore;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MovieService : IService
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

        public List<IDomainObject> GetAll()
        {
            return ConvertToListOfIdomainObject(MovieRepo.GetAll());
        }

        public List<IDomainObject> ConvertToListOfIdomainObject(List<Movie> listOfMovie)
        {
            var Ilist = new List<IDomainObject>();
            try
            {
                foreach (var item in listOfMovie)
                {
                    Ilist.Add(item);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return Ilist;
        }

        public List<Movie> ConvertToListOfMovie(List<IDomainObject> listOfDomainObj)
        {
            var ml = new List<Movie>();
            foreach (var item in listOfDomainObj)
            {
                ml.Add(item as Movie);
            }
            return ml;
        }


    }
}
