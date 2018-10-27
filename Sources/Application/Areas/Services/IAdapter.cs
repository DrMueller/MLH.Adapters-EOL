namespace Mmu.Mlh.Adapters.Areas.Services
{
    public interface IAdapter<TDto, TModel>
    {
        TDto Adapt(TModel model);

        TModel Adapt(TDto dto);
    }
}