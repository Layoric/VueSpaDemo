using System;
using ServiceStack;
using VueSpaDemo.ServiceModel;

namespace VueSpaDemo.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
