using Microsoft.Practices.Unity;
using System.Web.Http;
using Ucodia.SimpleAuth.Services;
using Unity.WebApi;

namespace Ucodia.SimpleAuth
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IApiKeyProvider, SimpleApiKeyProvider>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}