using Microsoft.AspNetCore.Antiforgery;
using Xtd.AngularWebApp.Controllers;

namespace Xtd.AngularWebApp.Web.Host.Controllers
{
    public class AntiForgeryController : AngularWebAppControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
