using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace StringLocalizerAPI.Helpers
{
    public class MyCustomRequestCultureProvider : RequestCultureProvider
    {
        public override async Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            //await Task.Yield();

            return await Task.Run(() =>
            {
                httpContext.Request.Query.TryGetValue("langCode", out var culture);
                return new ProviderCultureResult(culture.ToString());
            });
        }
    }
}
