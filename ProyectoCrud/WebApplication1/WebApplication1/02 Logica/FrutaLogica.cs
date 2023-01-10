using WebApplication1._03_Repositorio;
using WebApplication1.BDCRUD;
using WebApplication1.Model;

namespace WebApplication1._02_Logica
{
    public class FrutaLogica
    {

        FrutaRepositorio repo = new FrutaRepositorio();

        public List<Fruta> getAll()
        {
            //select * from Fruta
            return repo.getAll();
        }


        //select * from Fruta wherd id = id
        public Fruta getById(int id)
        {
            //select * from Fruta
            return repo.getById(id);
        }


        //insert into Fruta
        //select * from Fruta wherd id = id
        public Fruta create(Fruta request)
        {
            //request.id = 0 // 4

            return repo.create(request);
        }

        //update into Fruta
        //select * from Fruta wherd id = id
        public Fruta update(Fruta request)
        {
            return repo.update(request);
        }


        public int delete(int id)
        {

            return repo.delete(id);
        }

        public List<Fruta> getByFilter(int? id_categoria, string? nombre)
        {

            return repo.getByFilter(id_categoria, nombre);

        }

        public GenericFilterResponse<Fruta> getByFilterGeneric(GenericFilterRequest filters)
        {
            return repo.getByFilterGeneric(filters);
        }

    }
}
