using WebApplication1._03_Repositorio;
using WebApplication1.BDCRUD;

namespace WebApplication1._02_Logica
{
    public class ProductoLogica
    {
        ProductoRepositorio repo = new ProductoRepositorio();

        public List<Producto> getAll()
        {
            //select * from producto
            return repo.getAll();
        }


        //select * from producto wherd id = id
        public Producto getById(int id)
        {
            //select * from producto
            return repo.getById(id);
        }


        //insert into producto
        //select * from producto wherd id = id
        public Producto create(Producto request)
        {
            //request.id = 0 // 4

            return repo.create(request);
        }

        //update into producto
        //select * from producto wherd id = id
        public Producto update(Producto request)
        {
            return repo.update(request);
        }


        public int delete(int id)
        {

            return repo.delete(id);
        }

    }
}
