using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CitySite.Routing
{
    public class CityInfoModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
    
            // We only want to invoke our custom provider for ICityInfo implementors
            if (context.Metadata?.ModelType == typeof(ICityInfo))
            {
                return new CityInfoModelBinder();
            }
    
            return null;
        }
    }
}