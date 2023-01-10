using WebApplication1._02_Logica.Interface;
using WebApplication1._03_Repositorio;
using WebApplication1._03_Repositorio.Implementacion;
using WebApplication1._03_Repositorio.Interfaces;
using WebApplication1.BDCRUD;
using WebApplication1.Model;

namespace WebApplication1._02_Logica.Implementacion
{
    public class NewFrutaLogica : IFrutaLogica<Fruta>
    {
        /*INYECCIÓN DE DEPENDENCIAS*/

        private readonly IFrutaRepositorio<Fruta> _repo;


        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public NewFrutaLogica()
        {
            _repo = new NewFrutaRepositorio();
        }

        public Fruta create(Fruta entity)
        {
            return _repo.create(entity);
        }

        public int delete(object id)
        {
            return _repo.delete(id);
        }

        public int deleteMultipleItems(List<Fruta> lista)
        {
            return _repo.deleteMultipleItems(lista);
        }

        public List<Fruta> getAll()
        {
            return _repo.getAll();
        }

        public GenericFilterResponse<Fruta> getByFilterGeneric(GenericFilterRequest filters)
        {
            return _repo.getByFilterGeneric(filters);
        }

        public Fruta getById(object id)
        {
            return _repo.getById(id);
        }

        public List<Fruta> insertMultiple(List<Fruta> lista)
        {
            return _repo.insertMultiple(lista);
        }

        public Fruta update(Fruta entity)
        {
            return _repo.update(entity);
        }

        public List<Fruta> updateMultiple(List<Fruta> lista)
        {
            return _repo.updateMultiple(lista);
        }
    }
}
