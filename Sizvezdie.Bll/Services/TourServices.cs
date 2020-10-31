using System.Threading.Tasks;
using AutoMapper;
using Sozvezdie.BLL.Interfaces;
using Sozvezdie.BLL.Models;
using Sozvezdie.DAL.Interfaces;
using Sozvezdie.DAL.Models;

namespace Sozvezdie.BLL.Services
{
    public class TourServices : ITourServices
    {
        private readonly ITourRepository _tourRepository;
        private readonly IMapper _mapper;

        public TourServices(IMapper mapper,
            ITourRepository tourRepository)
        {
            _mapper = mapper;
            _tourRepository = tourRepository;
        }

        public Task CrateTourAsync(TourModel model)
        {
            var tourEntity = _mapper.Map<Tour>(model);
            _tourRepository.CreateTourAsync(tourEntity);
            return Task.CompletedTask;
        }

        public async Task<TourModel> GetTourAsync(int id)
        {
            var tour = await _tourRepository.FindTourByIdAsync(id);
            var tourModel = _mapper.Map<TourModel>(tour);
            return tourModel;
        }

        public async Task EditTourAsync(TourModel model)
        {
            var tourEntity = _mapper.Map<Tour>(model);
            await _tourRepository.UpdateTourAsync(tourEntity);
        }

        public bool DeleteTour(int id)
        {
            var answer = _tourRepository.DeleteTour(id);
            return answer;
        }
    }
}