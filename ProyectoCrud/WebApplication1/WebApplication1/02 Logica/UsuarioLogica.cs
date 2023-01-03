using WebApplication1._01_Seguridad;
using WebApplication1._03_Repositorio;
using WebApplication1.BDCRUD;
using WebApplication1.Model;

namespace WebApplication1._02_Logica
{
    public class UsuarioLogica
    {
        UsuarioRepositorio repo = new UsuarioRepositorio();

        #region crud methods
        public List<Usuario> getAll()
        {
            //select * from producto
            return repo.getAll();
        }


        //select * from producto wherd id = id
        public Usuario getById(int id)
        {
            //select * from producto
            return repo.getById(id);
        }


        //insert into producto
        //select * from producto wherd id = id
        public Usuario create(Usuario request)
        {

            request.Password = UtilCripto.encriptar_AES(request.Password);
            return repo.create(request);
        }

        //update into producto
        //select * from producto wherd id = id
        public Usuario update(Usuario request)
        {
            //tenemos que definir que campos vamos a actualizar
            Usuario user = getById(request.Id);
            user.FullName = request.FullName;
            user.Username = request.Username;
            user.IdRole = request.IdRole;
            user.DateChangedPassword = request.DateChangedPassword;
            user.ChangedPassword = request.ChangedPassword;
            return repo.update(request);
        }


        public int delete(int id)
        {
            return repo.delete(id);
        }
        #endregion crud methods


        #region proceso de validacion de login

        public LoginResponse login(LoginRequest request)
        {
            LoginResponse response = new LoginResponse();
            response.Success = false;
            response.user = null;
            response.Message = "Usuario y/o password incorrecto";


            /*
             1 => SI USUARIO Y PASSWORD COINCIDEN 
                    ==> LOGIN SATISFACTORIO
             --------------------------------------------
               1.1 Debo obtener el registro del usuario
                    por el username
               1.2 compara el resultado del 1.1, con la 
                información que recibo del request
             */

            Usuario userBD = repo.getByUserName(request.UserName);

            if(userBD == null)
            {
                return response;
            }

            //fhuaman ==> fHuaman
            //pwd BD == mT9JyfEsDofFcNfJaAmjTg==
            //pwd REQ == 123456
            request.Password = UtilCripto.encriptar_AES(request.Password);
            if (
                !(
                    userBD.Username.ToLower() == request.UserName.ToLower()
                    && userBD.Password == request.Password
                   )
               )
            {
                return response;
            }

            response.Success = true;
            response.Message = "Login Correcto";
            response.user = new UsuarioLoginResponse();
            response.user.Username = userBD.Username;
            response.user.IdRole = userBD.IdRole;
            response.user.ChangedPassword = userBD.ChangedPassword;
            response.user.FullName = userBD.FullName;
            response.user.Id = userBD.Id;
            response.user.role = new RoleResponse();
            response.user.role.Id = userBD.IdRoleNavigation.Id;
            response.user.role.Description = userBD.IdRoleNavigation.Description;
            response.user.role.Function = userBD.IdRoleNavigation.Function;
            response.user.role.IdStatus = userBD.IdRoleNavigation.IdStatus;
            return response;
        }

        #endregion proceso de validacion de login




    }
}
