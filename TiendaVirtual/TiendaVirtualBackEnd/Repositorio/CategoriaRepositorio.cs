using Data.DBTercerCiclo;
using DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        _DbContextTercerCiclo db;
        public CategoriaRepositorio()
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
        public Categoria Create(Categoria request)
        {
            db.Categorias.Add(request); // insert into 
            db.SaveChanges(); // guardando los cambios en base de datos
            return request;
        }

        public List<Categoria> CreateMultiple(List<Categoria> request)
        {
            db.Categorias.AddRange(request);
            db.SaveChanges();
            return request;

        }

        public int delete(int id)
        {
            Categoria product = db.Categorias.Find(id);
            db.Categorias.Remove(product);
            return db.SaveChanges();
        }


        public List<Categoria> GetAll()
        {
            List<Categoria> Categorias = db.Categorias.ToList();
            return Categorias;
        }

        public Categoria GetById(int id)
        {
            Categoria product = db.Categorias.Find(id);
            return product;
        }

        public Categoria Update(Categoria request)
        {
            db.Categorias.Update(request); // update
            db.SaveChanges(); // guardando los cambios en base de datos
            return request;
        }

        public List<Categoria> UpdateMultiple(List<Categoria> request)
        {
            db.Categorias.UpdateRange(request);
            db.SaveChanges();
            return request;
        }

    }
}
