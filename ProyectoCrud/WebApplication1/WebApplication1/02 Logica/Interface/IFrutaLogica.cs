using WebApplication1.Model;

namespace WebApplication1._02_Logica.Interface
{
    public interface IFrutaLogica<T>
    {
        List<T> getAll();
        T getById(object id);
        T create(T entity);
        T update(T entity);
        int delete(object id);
        List<T> updateMultiple(List<T> lista);
        int deleteMultipleItems(List<T> lista);
        List<T> insertMultiple(List<T> lista);
        GenericFilterResponse<T> getByFilterGeneric(GenericFilterRequest filters);
    }
}
