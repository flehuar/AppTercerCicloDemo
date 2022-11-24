using AppTercerCicloDemo01.DBTercerCiclo;

namespace AppTercerCicloDemo01.Repositorio
{
    public class ProductoRepositorio
    {

        private _DbContextTercerCiclo db = new _DbContextTercerCiclo();


        public List<Producto> getAll()
        {
            // db.Productos.ToList(); estamos haciendo un select * from producto
            List<Producto> productos = db.Productos.ToList();
            return productos;
        }

        public Producto getById(int id)
        {
            // db.Productos.ToList(); estamos haciendo un select * from producto where pk = id
            Producto product = db.Productos.Find(id);
            return product;
        }

        public Producto create(Producto request)
        {
            db.Productos.Add(request); // insert into 
            db.SaveChanges(); // guardando los cambios en base de datos
            return request;
        }


        public Producto update(Producto request)
        {
            db.Productos.Update(request); // update
            db.SaveChanges(); // guardando los cambios en base de datos
            return request;

            //Producto obj = db.Productos.Find(request.Id);
            //obj.Estado = request.Estado;
            //db.Productos.Update(obj); // update
            //db.SaveChanges(); // guardando los cambios en base de datos
            //return obj;
        }

        public int delete(int id)
        {
            Producto product = db.Productos.Find(id);
            db.Productos.Remove(product);
            return db.SaveChanges();
        }


    }
}
