using Model;

namespace NegocioInterface
{
    public interface IProductoNegocio:IDisposable
    {
        public List<ProductoResponse> GetAll();
        public ProductoResponse GetById(int id);
        public ProductoResponse Create(ProductoRequest request);
        public ProductoResponse Update(ProductoRequest request);
        public int delete(int id);
        public List<ProductoResponse> CreateMultiple(List<ProductoRequest> request);
        public List<ProductoResponse> UpdateMultiple(List<ProductoRequest> request);
    }
}