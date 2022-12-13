
using AutoMapper;
using Data.DBTercerCiclo;
using Model;

namespace Utilitarios
{
    public class AutoMapperProfiles : Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<ProductoRequest, Producto>().ReverseMap();
            CreateMap<ProductoResponse, Producto>().ReverseMap();

            CreateMap<CategoriaRequest, Categoria>().ReverseMap();
            CreateMap<Categoria, CategoriaResponse>().ReverseMap();


        }
    }
}