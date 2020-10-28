using System.Threading.Tasks;
using Sozvezdie.BLL.Models;
using Sozvezdie.DAL.Models;

namespace Sozvezdie.DAL.Interfaces
{
    public interface IRepositories
    {
        Task<Tour> GetOrCreateTourAsync(TourModel model);
        Task<Tour> FindTourByIdAsync(int id);
        bool DeleteTour(int id);
        Task UpdateTourAsync(TourModel model);
    }
}