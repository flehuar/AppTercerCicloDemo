namespace WebApplication1.Model
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        /// <summary>
        /// JWT JSON WEB TOKEN
        /// </summary>
        public string Token { get; set; }
        public string Message { get; set; }
        public UsuarioLoginResponse user { get; set; }
    }
}