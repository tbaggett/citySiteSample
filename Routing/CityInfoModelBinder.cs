using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CitySite.Routing
{
    public class CityInfoModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
    
            string cityFragment = 
                context.ActionContext.RouteData.Values[context.FieldName]?
                    .ToString().ToLowerInvariant();
                    
            // Assign the matched city info if found
            if (cityFragment != null && CityInfo.Cities.ContainsKey(cityFragment))
            {
                context.Result = ModelBindingResult.Success(CityInfo.Cities[cityFragment]);
            }
    
            return Task.CompletedTask;
        }
    }
}