using WebApplication1._03_Repositorio.comun;
using WebApplication1._03_Repositorio.Interfaces;
using WebApplication1.BDCRUD;
using WebApplication1.Model;

namespace WebApplication1._03_Repositorio.Implementacion
{
    public class NewFrutaRepositorio : GenericRepository<Fruta>, IFrutaRepositorio<Fruta>
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public GenericFilterResponse<Fruta> getByFilterGeneric(GenericFilterRequest filters)
        {
            GenericFilterResponse<Fruta> res = new GenericFilterResponse<Fruta>();

            //vue react angular php ==> null ==> "null"
            var query = db.Frutas.Where(x => x.Id == x.Id);
            filters.filters.ForEach(item => {
                if (!string.IsNullOrEmpty(item.value) && item.value != "null")
                {
                    switch (item.name)
                    {
                        case "id":
                            query = query.Where(x => x.Id == int.Parse(item.value));
                            break;
                        case "id_categoria":
                            query = query.Where(x => x.IdFrutaCategoria == int.Parse(item.value));
                            break;
                        case "nombre":
                            query = query.Where(x => x.Nombre.ToLower().Contains(item.value.ToLower()));
                            break;
                    }
                }

            });

            //el total de los items encontradas
            res.totalRecord = query.Count();
            List<Fruta> lst = query
                .Skip((filters.page - 1) * filters.quantity).Take(filters.quantity)
                .ToList();
            res.list = lst;

            return res;
        }
    }
}
