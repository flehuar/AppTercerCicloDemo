using WebApplication1.BDCRUD;

namespace WebApplication1._03_Repositorio
{
    public class FrutaCategoriaRepositorio
    {
        _DbContextCrud db = new _DbContextCrud();

        #region crud methods
        public List<FrutaCategoria> getAll()
        {
            //select * from FrutaCategoria
            return db.FrutaCategorias.ToList();
        }


        //select * from FrutaCategoria wherd id = id
        public FrutaCategoria getById(int id)
        {
            //select * from FrutaCategoria
            return db.FrutaCategorias.Find(id);
        }


        //insert into FrutaCategoria
        //select * from FrutaCategoria wherd id = id
        public FrutaCategoria create(FrutaCategoria request)
        {
            //request.id = 0 // 4
            db.FrutaCategorias.Add(request);
            db.SaveChanges();
            return request;
        }

        //update into FrutaCategoria
        //select * from FrutaCategoria wherd id = id
        public FrutaCategoria update(FrutaCategoria request)
        {
            //request.id = 0 // 4
            db.FrutaCategorias.Update(request);
            db.SaveChanges();
            return request;
        }


        public int delete(int id)
        {

            //select * from FrutaCategoria wherd id = id
            FrutaCategoria FrutaCategoria = db.FrutaCategorias.Find(id);
            //request.id = 0 // 4
            db.FrutaCategorias.Remove(FrutaCategoria);
            return db.SaveChanges();
        }
        #endregion crud methods



    }
}
