using AutoMapper;
using Sozvezdie.BLL.Models;
using Sozvezdie.DAL.Models;

namespace Sozvezdie
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Tour, TourModel>();
            CreateMap<TourModel, Tour>();
            CreateMap<PhotoAlbum, PhotoAlbumModel>();
            CreateMap<PhotoCard, PhotoCardModel>();
        }
    }
}