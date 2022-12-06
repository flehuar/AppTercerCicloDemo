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
            Producto producto = _mapper.Map<Producto>(request);
            producto = _productoRepositorio.Create(producto);
            ProductoResponse response = _mapper.Map<ProductoResponse>(producto);
            return response;
        }



        public int delete(int id)
        {
            return _productoRepositorio.delete(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
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
            Producto producto = _productoRepositorio.GetById(id);
            ProductoResponse response = _mapper.Map<ProductoResponse>(producto);
            return response;
        }

        public ProductoResponse Update(ProductoRequest request)
        {

            Producto producto = _mapper.Map<Producto>(request);
            producto = _productoRepositorio.Update(producto);
            ProductoResponse response = _mapper.Map<ProductoResponse>(producto);
            return response;
        }


        public List<ProductoResponse> CreateMultiple(List<ProductoRequest> request)
        {
            List<Producto> productos = _mapper.Map<List<Producto>>(request);
            productos = _productoRepositorio.CreateMultiple(productos);
            List<ProductoResponse> response = _mapper.Map<List<ProductoResponse>>(productos);
            return response;
        }
        public List<ProductoResponse> UpdateMultiple(List<ProductoRequest> request)
        {
            List<Producto> productos = _mapper.Map<List<Producto>>(request);
            productos = _productoRepositorio.UpdateMultiple(productos);
            List<ProductoResponse> response = _mapper.Map<List<ProductoResponse>>(productos);
            return response;
        }
    }
}