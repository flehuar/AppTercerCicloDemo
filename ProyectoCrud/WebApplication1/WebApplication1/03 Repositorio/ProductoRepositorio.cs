using WebApplication1.BDCRUD;

namespace WebApplication1._03_Repositorio
{
    public class ProductoRepositorio
    {
        _DbContextCrud db = new _DbContextCrud();


        public List<Producto> getAll()
        {
            //select * from producto
            return db.Productos.ToList();
        }


        //select * from producto wherd id = id
        public Producto getById(int id)
        {
            //select * from producto
            return db.Productos.Find(id);
        }


        //insert into producto
        //select * from producto wherd id = id
        public Producto create(Producto request)
        { 
            //request.id = 0 // 4
            db.Productos.Add(request);
            db.SaveChanges();
            return request;
        }

        //update into producto
        //select * from producto wherd id = id
        public Producto update(Producto request)
        {
            //request.id = 0 // 4
            db.Productos.Update(request);
            db.SaveChanges();
            return request;
        }


        public int delete(int id)
        {

            //select * from producto wherd id = id
            Producto producto = db.Productos.Find(id);
            //request.id = 0 // 4
            db.Productos.Remove(producto);
            return db.SaveChanges();
        }

    }
}
