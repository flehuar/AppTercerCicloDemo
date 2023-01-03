using Microsoft.EntityFrameworkCore;
using WebApplication1.BDCRUD;

namespace WebApplication1._03_Repositorio
{
    public class UsuarioRepositorio
    {
        _DbContextCrud db = new _DbContextCrud();


        public List<Usuario> getAll()
        {
            //select * from producto
            return db.Usuarios.ToList();
        }


        //select * from producto wherd id = id
        public Usuario getById(int id)
        {
            //select * from producto
            return db.Usuarios.Find(id);
        }


        //insert into producto
        //select * from producto wherd id = id
        public Usuario create(Usuario request)
        {
            //request.id = 0 // 4
            db.Usuarios.Add(request);
            db.SaveChanges();
            return request;
        }

        //update into producto
        //select * from producto wherd id = id
        public Usuario update(Usuario request)
        {
            //request.id = 0 // 4
            db.Usuarios.Update(request);
            db.SaveChanges();
            return request;
        }


        public int delete(int id)
        {

            //select * from producto wherd id = id
            Usuario usuario = db.Usuarios.Find(id);
            //request.id = 0 // 4
            db.Usuarios.Remove(usuario);
            return db.SaveChanges();
        }


        public Usuario getByUserName(string username)
        {
            /*
             select * from usuario
             where username = 'fhuaman'
             */

            Usuario user =
                    db.Usuarios
                    .Where(x =>
                    x.Username.ToLower() == username.ToLower()
                    )
                    .Include(x =>x.IdRoleNavigation)
                    .FirstOrDefault();


            return user;
        }

    }
}
