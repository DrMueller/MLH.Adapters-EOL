using Lamar;
using Mmu.Mlh.Adapters.Areas.Services;
using Mmu.Mlh.Adapters.Areas.Services.Implementation;

namespace Mmu.Mlh.Adapters.Infrastructure.DependencyInjection
{
    public class AdaptersRegistry : ServiceRegistry
    {
        public AdaptersRegistry()
        {
            Scan(
                scanner =>
                {
                    scanner.AssemblyContainingType<AdaptersRegistry>();
                    scanner.WithDefaultConventions();
                });

            For<IAdapterResolver>().Use<AdapterResolver>().Singleton();
        }
    }
}