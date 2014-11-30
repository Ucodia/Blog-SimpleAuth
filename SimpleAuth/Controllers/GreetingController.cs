using System.Web.Http;
using Ucodia.SimpleAuth.Filters;

namespace Ucodia.SimpleAuth.Controllers
{
    [ApiKeyAuthorize]
    public class GreetingController : ApiController
    {
        // GET api/greeting
        public string Get()
        {
            return "Hello World!";
        }
    }
}
