using Sozvezdie.DAL.Interfaces;
using Sozvezdie.DAL.Models;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sozvezdie.DAL.Repositories
{
    public class TourRepository : ITourRepository
    {
        private readonly ConcurrentDictionary<int, Tour> _tours = new ConcurrentDictionary<int, Tour>();
        
        public Task<Tour> CreateTourAsync(Tour model)
        {
            if (!_tours.TryGetValue(model.Id, out var tour))
            {
                _tours[model.Id] = tour;
            }
            return Task.FromResult(tour.Clone());
        }

        public Task<Tour> FindTourByIdAsync(int id)
        { 
            var tour = _tours.Values.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(tour?.Clone());
        }
        

        //TODO 3 : Add async method 
        public bool DeleteTour(int id)
        {
            var removeResult = _tours.TryRemove(id, out _);
            return removeResult;
        }

        public Task UpdateTourAsync(Tour model)
        {
            if (!_tours.TryGetValue(model.Id, out var tour))
            {
                //TODO 4 : Add mapping model for all parameters
                tour.Title = model.Title;
                tour.Description = model.Description;
            }
            return Task.CompletedTask;
        }

        public void AddData(IEnumerable<Tour> model)
        {
            foreach (var tour in model)
            {
                _tours[tour.Id] = tour;
            }
        }
    }
}