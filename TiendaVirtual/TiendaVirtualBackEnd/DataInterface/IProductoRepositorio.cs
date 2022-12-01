using Data.DBTercerCiclo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface
{
    public interface IProductoRepositorio:IDisposable
    {
        public List<Producto> GetAll();
        public Producto GetById(int id);
        public Producto Create(Producto request);
        public Producto Update(Producto request);
        public int delete(int id);
        public List<Producto> CreateMultiple(List<Producto> request);
        public List<Producto> UpdateMultiple(List<Producto> request);


    }
}
