namespace Mmu.Mlh.Adapters.Areas.Services
{
    public interface IAdapterResolver
    {
        IAdapter<TDto, TModel> ResolveByAdapteeTypes<TDto, TModel>();

        TAdapter ResolveByAdapterType<TAdapter>();
    }
}