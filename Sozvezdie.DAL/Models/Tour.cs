using System;
using System.Collections.Generic;

namespace Sozvezdie.DAL.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public decimal MinPrice { get; set; }
        public List<string> Route { get; set; }
        public PhotoCard PhotoCard { get; set; }
        public List<PhotoAlbum> PhotoAlbum { get; set; }
        public Tour Clone() => (Tour)MemberwiseClone();
    }
}