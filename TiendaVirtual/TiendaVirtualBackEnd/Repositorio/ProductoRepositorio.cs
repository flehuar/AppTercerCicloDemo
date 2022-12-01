using Data.DBTercerCiclo;
using DataInterface;

namespace Repositorio
{
    public class ProductoRepositorio : IProductoRepositorio
    {

        _DbContextTercerCiclo db;
        /// <summary>
        /// constructor inicializar algunas variables
        /// </summary>
        public ProductoRepositorio()
        {
            db = new _DbContextTercerCiclo();
        }

        /// <summary>
        /// Limpiar la memoria cache 
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public Producto Create(Producto request)
        {
            db.Productos.Add(request); // insert into 
            db.SaveChanges(); // guardando los cambios en base de datos
            return request;
        }

        public List<Producto> CreateMultiple(List<Producto> request)
        {
            db.Productos.AddRange(request);
            db.SaveChanges();
            return request;

        }

        public int delete(int id)
        {
            Producto product = db.Productos.Find(id);
            db.Productos.Remove(product);
            return db.SaveChanges();
        }


        public List<Producto> GetAll()
        {
            List<Producto> productos = db.Productos.ToList();
            return productos;
        }

        public Producto GetById(int id)
        {
            Producto product = db.Productos.Find(id);
            return product;
        }

        public Producto Update(Producto request)
        {
            db.Productos.Update(request); // update
            db.SaveChanges(); // guardando los cambios en base de datos
            return request;
        }

        public List<Producto> UpdateMultiple(List<Producto> request)
        {
            db.Productos.UpdateRange(request);
            db.SaveChanges();
            return request;
        }
    }
}