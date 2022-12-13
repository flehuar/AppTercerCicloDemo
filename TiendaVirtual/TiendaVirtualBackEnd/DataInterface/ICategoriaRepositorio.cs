using Data.DBTercerCiclo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface
{
    public interface ICategoriaRepositorio:IDisposable
    {
        public List<Categoria> GetAll();
        public Categoria GetById(int id);
        public Categoria Create(Categoria request);
        public Categoria Update(Categoria request);
        public int delete(int id);
        public List<Categoria> CreateMultiple(List<Categoria> request);
        public List<Categoria> UpdateMultiple(List<Categoria> request);


    }
}
