using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioInterface
{
    public interface ICategoriaNegocio:IDisposable
    {
        public List<CategoriaResponse> GetAll();
        public CategoriaResponse GetById(int id);
        public CategoriaResponse Create(CategoriaRequest request);
        public CategoriaResponse Update(CategoriaRequest request);
        public int delete(int id);
        public List<CategoriaResponse> CreateMultiple(List<CategoriaRequest> request);
        public List<CategoriaResponse> UpdateMultiple(List<CategoriaRequest> request);
    }
}
