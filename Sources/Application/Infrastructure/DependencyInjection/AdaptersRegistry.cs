using Mmu.Mlh.Adapters.Areas.Services;
using Mmu.Mlh.Adapters.Areas.Services.Implementation;
using StructureMap;

namespace Mmu.Mlh.Adapters.Infrastructure.DependencyInjection
{
    public class AdaptersRegistry : Registry
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