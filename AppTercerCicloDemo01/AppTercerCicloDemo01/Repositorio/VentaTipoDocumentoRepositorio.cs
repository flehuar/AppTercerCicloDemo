using AppTercerCicloDemo01.DBTercerCiclo;

namespace AppTercerCicloDemo01.Repositorio
{
    public class VentaTipoDocumentoRepositorio
    {
        private _DbContextTercerCiclo db = new _DbContextTercerCiclo();


        public List<VentaTipoDocumento> getAll()
        {
            // db.Productos.ToList(); estamos haciendo un select * from producto
            List<VentaTipoDocumento> tipos = db.VentaTipoDocumentos.ToList();
            return tipos;
        }

        public VentaTipoDocumento getById(int id)
        {
            // db.Productos.ToList(); estamos haciendo un select * from producto where pk = id
            VentaTipoDocumento product = db.VentaTipoDocumentos.Find(id);
            return product;
        }

        public VentaTipoDocumento create(VentaTipoDocumento request)
        {
            db.VentaTipoDocumentos.Add(request); // insert into 
            db.SaveChanges(); // guardando los cambios en base de datos
            return request;
        }


        public VentaTipoDocumento update(VentaTipoDocumento request)
        {
            db.VentaTipoDocumentos.Update(request); // update
            db.SaveChanges(); // guardando los cambios en base de datos
            return request;

        }

        public int delete(int id)
        {
            VentaTipoDocumento product = db.VentaTipoDocumentos.Find(id);
            db.VentaTipoDocumentos.Remove(product);
            return db.SaveChanges();
        }
    }
}
