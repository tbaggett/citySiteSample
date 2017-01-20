using System.Collections.Generic;

namespace CitySite.Models
{
    public class CityNewsViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Headlines { get; set; }
    }
}