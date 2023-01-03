using WebApplication1.BDCRUD;

namespace WebApplication1.Model
{
    public class UsuarioLoginResponse
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Username { get; set; }
        public bool? ChangedPassword { get; set; }
        public short? IdRole { get; set; }
        public RoleResponse role { get; set; }
    }
}
