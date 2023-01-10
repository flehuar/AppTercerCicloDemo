using WebApplication1._03_Repositorio.comun;
using WebApplication1.Model;

namespace WebApplication1._03_Repositorio.Interfaces
{
    public interface IProductoInterface<T>: ICRUDRepositorio<T>
    {
        List<T> GetFilterPersonalizadoPeticionContabilidad();
    }
}
