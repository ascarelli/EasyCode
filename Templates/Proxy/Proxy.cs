using [NAMESPACE].TO.Response;
using Prodesp.Gsnet.Core.Presentation.Interfaces;
using Prodesp.Gsnet.Core.Presentation.Proxy;
using RestSharp;

namespace [NAMESPACE].Proxy
{
    public static class [ENTITY]Proxy
    {
        public static string URL { get; set; }
        private static string endPoint
        {
            get
            {
                return "api/[ENTITY]/";
            }
        }
    }
}
