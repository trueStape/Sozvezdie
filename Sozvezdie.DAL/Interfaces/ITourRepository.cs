using System.Threading.Tasks;
using Sozvezdie.BLL.Models;
using Sozvezdie.DAL.Models;

namespace Sozvezdie.DAL.Interfaces
{
    public interface ITourRepository
    {
        Task<Tour> GetOrCreateTourAsync(Tour model);
        Task<Tour> FindTourByIdAsync(int id);
        bool DeleteTour(int id);
        Task UpdateTourAsync(Tour model);
    }
}