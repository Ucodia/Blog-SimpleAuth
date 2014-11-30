using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Ucodia.SimpleAuth.Services;

namespace Ucodia.SimpleAuth.Filters
{
    public class ApiKeyAuthorizeAttribute : ActionFilterAttribute
    {
        private const string ApiKeyHeaderName = "ApiKey";

        public override void OnActionExecuting(HttpActionContext filterContext)
        {
            // Get API key provider
            var provider = filterContext.ControllerContext.Configuration
                .DependencyResolver.GetService(typeof(IApiKeyProvider)) as IApiKeyProvider;

            // Get ApiKey header data
            IEnumerable<string> apiKeys;
            filterContext.Request.Headers.TryGetValues(ApiKeyHeaderName, out apiKeys);

            // Check API key
            if (apiKeys == null || apiKeys.FirstOrDefault() != provider.GetApiKey())
            {
                filterContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }

            base.OnActionExecuting(filterContext);
        }
    }
}