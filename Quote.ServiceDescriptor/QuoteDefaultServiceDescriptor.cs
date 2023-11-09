using LightInject;
using Quote.Contracts;
using System.Net.Http
    ;

namespace Quote.ServiceDescriptor
{
    public static class QuoteDefaultServiceDescriptor
    {
        public static void Register(IServiceContainer container)
        {
            container.Register<IMarginProvider, DefaultMarginProvider>();
            container.Register<IMapper, Mapper>();
            container.Register<IServiceWrapper, ServiceApitude>();
            container.Register<IQuoteEngine, QuoteService>();
            container.Register<IMarginProvider, MarginProvider>();
        }
    }
}
