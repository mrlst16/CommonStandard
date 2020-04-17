using System.Threading.Tasks;

namespace CommonStandard.Interface.Mappers
{
    public interface IMapper<TIn, TOut>
    {
        Task<TOut> Map(TIn source);
    }
}
