using System.Threading.Tasks;
using Sozvezdie.BLL.Models;

namespace Sozvezdie.BLL.Interfaces
{
    public interface ITourServices
    {
        Task CrateTourAsync(TourModel model);
        Task<TourModel> GetTourAsync(int id);
        Task EditTourAsync(TourModel model);
        bool DeleteTour(int id);
    }
}