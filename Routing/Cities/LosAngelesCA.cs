using System.Collections.Generic;
using CitySite.Models;

namespace CitySite.Routing.Cities
{
    public class LosAngelesCA : ICityInfo
    {
        // Mocked data for demonstration purposes only
        public CityNewsViewModel CityNewsViewModel
        {
            get
            {
                return new CityNewsViewModel()
                {
                    Name = "Los Angeles, California",
                    Description = "Los Angeles, officially the City of Los Angeles and often known by its initials L.A., " +
                        "is the second-most populous city in the United States (after New York City), the most populous city in " +
                        "California and the county seat of Los Angeles County. Situated in Southern California, Los Angeles is " +
                        "known for its mediterranean climate, ethnic diversity, sprawling metropolis, and as a major center of " +
                        "the American entertainment industry. Los Angeles lies in a large coastal basin surrounded on three sides " +
                        "by mountains reaching up to and over 10,000 feet (3,000 m).",
                    Headlines = new List<string>()
                    {
                        "Man who smoked meth for 'several days' killed in shootout with deputies at Motel 6 in Twentynine Palms",
                        "City of Commerce swim coach accused of molesting 7-year-old girl at city's aquatic center",
                        "Video shows police cornering mentally ill man and fatally shooting him: 'This was an execution'",
                        "USC's recruiting fortunes have mirrored its on-field turnaround",
                        "Opera singers, jazz musicians roar into Union Station for one-night pop-up"
                    }
                };
            }
        }
    }
}