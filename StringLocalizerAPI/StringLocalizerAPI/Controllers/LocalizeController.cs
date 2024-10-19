using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using StringLocalizerAPI;

namespace StringLocalizerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocalizeController : ControllerBase
    {
        private readonly IStringLocalizer _localizer;
        //private readonly IStringLocalizerFactory localizerFactory;

        //public LocalizeController(IStringLocalizerFactory localizerFactory)
        //{
        //    this.localizerFactory = localizerFactory;
        //    localizer = localizerFactory.Create(typeof(SharedResource));
        //}

        public LocalizeController(IStringLocalizer localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        public string Index(string reqStr, string langCode)
        {
            return _localizer[reqStr].Value;
        }
    }
}
