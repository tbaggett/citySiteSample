using System.Collections.Generic;
using CitySite.Models;

namespace CitySite.Routing.Cities
{
    public class NewYorkNY : ICityInfo
    {
        // Mocked data for demonstration purposes only
        public CityNewsViewModel CityNewsViewModel
        {
            get
            {
                return new CityNewsViewModel()
                {
                    Name = "New York City, New York",
                    Description = "The City of New York, often called New York City or simply New York, is the " +
                    "most populous city in the United States. With an estimated 2015 population of 8,550,405 " +
                    "distributed over a land area of just 305 square miles (790 km2), New York City is also " +
                    "the most densely populated major city in the United States. Located at the southern tip " +
                    "of the state of New York, the city is the center of the New York metropolitan area, one " +
                    "of the most populous urban agglomerations in the world.",
                    Headlines = new List<string>()
                    {
                        "Revisions Coming for Admissions Tests to NYC’s Coveted High Schools",
                        "Cuomo Renews Millionaire’s Tax in Proposed Budget",
                        "Paul Massey Challenges New York City Mayor in Fundraising Effort",
                        "Bill to Halt NYC Plastic-Bag Fee Gains Steam in Albany",
                        "More NYC Students Passing Advanced Placement Tests"
                    }
                };
            }
        }
    }
}