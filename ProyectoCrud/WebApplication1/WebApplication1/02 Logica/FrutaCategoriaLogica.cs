using WebApplication1._03_Repositorio;
using WebApplication1.BDCRUD;

namespace WebApplication1._02_Logica
{
    public class FrutaCategoriaLogica
    {
        FrutaCategoriaRepositorio repo = new FrutaCategoriaRepositorio();

        public List<FrutaCategoria> getAll()
        {
            //select * from FrutaCategoria
            return repo.getAll();
        }


        //select * from FrutaCategoria wherd id = id
        public FrutaCategoria getById(int id)
        {
            //select * from FrutaCategoria
            return repo.getById(id);
        }


        //insert into FrutaCategoria
        //select * from FrutaCategoria wherd id = id
        public FrutaCategoria create(FrutaCategoria request)
        {
            //request.id = 0 // 4

            return repo.create(request);
        }

        //update into FrutaCategoria
        //select * from FrutaCategoria wherd id = id
        public FrutaCategoria update(FrutaCategoria request)
        {
            return repo.update(request);
        }


        public int delete(int id)
        {

            return repo.delete(id);
        }

    }
}
