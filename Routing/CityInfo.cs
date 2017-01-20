using System.Collections.Generic;
using CitySite.Routing.Cities;

namespace CitySite.Routing
{
    public static class CityInfo
    {
        public static readonly Dictionary<string, ICityInfo> Cities = 
            new Dictionary<string, ICityInfo>()
            {
                { "new-york-ny", new NewYorkNY() },
                { "los-angeles-ca", new LosAngelesCA() }
            };
    }
}