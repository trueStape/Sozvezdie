using System.Collections.Generic;

namespace Sozvezdie.BLL.Models
{
    public class TourModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string PeriodStart { get; set; }
        public string PeriodEnd { get; set; }
        public int MinPrice { get; set; }

        public List<RouteModel> Route { get; set; }
        public List<PhotoCardModel> PhotoCard { get; set; }
        public List<PhotoAlbumModel> PhotoAlbum { get; set; }
    }
}