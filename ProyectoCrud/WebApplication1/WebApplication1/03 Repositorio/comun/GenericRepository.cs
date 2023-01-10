using Microsoft.EntityFrameworkCore;
using WebApplication1.BDCRUD;

namespace WebApplication1._03_Repositorio.comun
{
    //INYECCIÓN DE DEPENDENCIAS
    //TEntity ==> clase que está relacionada a una tabla en base de datos
    //PROGRAMACIÓN ORIENTADA A OBJETOS ==> POLIMORFISMO
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal _DbContextCrud db = new _DbContextCrud();
        internal DbSet<TEntity> dbSet;

        //CONSIDERAR NUESTRO CONSTRUCTOR
        public GenericRepository()
        {
            try
            {
                this.dbSet = db.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //COMENZANDO CON LA SECCIÓN DE CRUD

        public virtual List<TEntity> getAll()
        {
            IQueryable<TEntity> query = dbSet;
            return query.ToList();
        }

        //PK ==> int, smallint, bigint, decimal, char, datetime, string
        public virtual TEntity getById(object id)
        {
            return dbSet.Find(id);
        }

        public virtual TEntity create(TEntity entity)
        {
            dbSet.Add(entity);
            db.SaveChanges();
            return entity;
        }


        public virtual TEntity update(TEntity entity)
        {
            dbSet.Update(entity);
            db.SaveChanges();
            return entity;
        }

        public virtual int delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            dbSet.Remove(entityToDelete);
            return db.SaveChanges();
        }

        public virtual List<TEntity> updateMultiple(List<TEntity> lista)
        {
            dbSet.UpdateRange(lista);
            db.SaveChanges();
            return lista;
        }

        public virtual int deleteMultipleItems(List<TEntity> lista)
        {
            dbSet.RemoveRange(lista);
            return db.SaveChanges();
        }

        public virtual List<TEntity> insertMultiple(List<TEntity> lista)
        {
            dbSet.AddRange(lista);
            db.SaveChanges();
            return lista;
        }
    }
}
