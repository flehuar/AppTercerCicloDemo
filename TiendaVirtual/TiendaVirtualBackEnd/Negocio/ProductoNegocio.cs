using AutoMapper;
using Data.DBTercerCiclo;
using DataInterface;
using Model;
using NegocioInterface;
using Repositorio;

namespace Negocio
{
    public class ProductoNegocio : IProductoNegocio
    {
        #region variables y constructor

        private readonly IProductoRepositorio _productoRepositorio;
        private readonly IMapper _mapper;
        public ProductoNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _productoRepositorio = new ProductoRepositorio();
        }


        #endregion




        public ProductoResponse Create(ProductoRequest request)
        {
            throw new NotImplementedException();
        }

        public List<ProductoResponse> CreateMultiple(List<ProductoRequest> request)
        {
            throw new NotImplementedException();
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ProductoResponse> GetAll()
        {
            List<Producto> productos = _productoRepositorio.GetAll();
            List<ProductoResponse> lstResponse = new List<ProductoResponse>();

            // forma primitiva 50 atributos
            //productos.ForEach(x => {
            //    ProductoResponse tmp = new ProductoResponse();
            //    tmp.Nombre = x.Nombre;
            //    tmp.IdCategoria = x.IdCategoria;
            //    tmp.Estado = x.Estado;
            //    tmp.Stock = x.Stock;
            //    lstResponse.Add(tmp);
            //});

            //FORMA CORRECTA
            lstResponse = _mapper.Map<List<ProductoResponse>>(productos);



            return lstResponse;
        }

        public ProductoResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ProductoResponse Update(ProductoRequest request)
        {
            throw new NotImplementedException();
        }

        public List<ProductoResponse> UpdateMultiple(List<ProductoRequest> request)
        {
            throw new NotImplementedException();
        }
    }
}