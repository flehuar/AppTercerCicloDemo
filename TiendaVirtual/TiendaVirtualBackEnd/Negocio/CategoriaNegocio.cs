using AutoMapper;
using Data.DBTercerCiclo;
using DataInterface;
using Model;
using NegocioInterface;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio: ICategoriaNegocio
    {
        #region variables y constructor

        private readonly ICategoriaRepositorio _CategoriaRepositorio;
        private readonly IMapper _mapper;
        public CategoriaNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _CategoriaRepositorio = new CategoriaRepositorio();
        }


        #endregion




        public CategoriaResponse Create(CategoriaRequest request)
        {
            Categoria Categoria = _mapper.Map<Categoria>(request);
            Categoria = _CategoriaRepositorio.Create(Categoria);
            CategoriaResponse response = _mapper.Map<CategoriaResponse>(Categoria);
            return response;
        }



        public int delete(int id)
        {
            return _CategoriaRepositorio.delete(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<CategoriaResponse> GetAll()
        {
            List<Categoria> Categorias = _CategoriaRepositorio.GetAll();
            List<CategoriaResponse> lstResponse = new List<CategoriaResponse>();
            lstResponse = _mapper.Map<List<CategoriaResponse>>(Categorias);
            return lstResponse;
        }

        public CategoriaResponse GetById(int id)
        {
            Categoria Categoria = _CategoriaRepositorio.GetById(id);
            CategoriaResponse response = _mapper.Map<CategoriaResponse>(Categoria);
            return response;
        }

        public CategoriaResponse Update(CategoriaRequest request)
        {

            Categoria Categoria = _mapper.Map<Categoria>(request);
            Categoria = _CategoriaRepositorio.Update(Categoria);
            CategoriaResponse response = _mapper.Map<CategoriaResponse>(Categoria);
            return response;
        }


        public List<CategoriaResponse> CreateMultiple(List<CategoriaRequest> request)
        {
            List<Categoria> Categorias = _mapper.Map<List<Categoria>>(request);
            Categorias = _CategoriaRepositorio.CreateMultiple(Categorias);
            List<CategoriaResponse> response = _mapper.Map<List<CategoriaResponse>>(Categorias);
            return response;
        }
        public List<CategoriaResponse> UpdateMultiple(List<CategoriaRequest> request)
        {
            List<Categoria> Categorias = _mapper.Map<List<Categoria>>(request);
            Categorias = _CategoriaRepositorio.UpdateMultiple(Categorias);
            List<CategoriaResponse> response = _mapper.Map<List<CategoriaResponse>>(Categorias);
            return response;
        }
    }
}