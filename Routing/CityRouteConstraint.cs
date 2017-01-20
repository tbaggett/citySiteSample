using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace CitySite.Routing
{
    public class CityRouteConstraint : IRouteConstraint
    {
        public const string ROUTE_LABEL = "cityRouteFragment";
        
        public bool Match(HttpContext httpContext, IRouter route, 
                        string routeKey, RouteValueDictionary values, 
                        RouteDirection routeDirection)
        {
            return CityInfo.Cities.ContainsKey(values[routeKey]?.ToString().ToLowerInvariant());
        }
    }
}