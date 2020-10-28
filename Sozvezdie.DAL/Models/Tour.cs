using System.Collections.Generic;

namespace Sozvezdie.DAL.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string PeriodStart { get; set; }
        public string PeriodEnd { get; set; }
        public int MinPrice { get; set; }

        public List<Route> Route { get; set; }
        public List<PhotoCard> PhotoCard { get; set; }
        public List<PhotoAlbum> PhotoAlbum { get; set; }
        public Tour Clone() => (Tour)MemberwiseClone();
    }
}