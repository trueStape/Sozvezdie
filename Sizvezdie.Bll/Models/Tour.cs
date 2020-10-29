using System;
using System.Collections.Generic;

namespace Sozvezdie.BLL.Models
{
    public class TourModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public decimal MinPrice { get; set; }
        public List<string> Route { get; set; }
        public PhotoCardModel PhotoCard { get; set; }
        public List<PhotoAlbumModel> PhotoAlbum { get; set; }
    }
}