using Sozvezdie.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sozvezdie.DAL.Interfaces
{
    public interface ITourRepository
    {
        Task<Tour> CreateTourAsync(Tour model);
        Task<Tour> FindTourByIdAsync(int id);
        bool DeleteTour(int id);
        Task UpdateTourAsync(Tour model);
        void AddData(IEnumerable<Tour> model);
    }
}