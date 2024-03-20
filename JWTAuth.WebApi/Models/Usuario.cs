namespace JWTAuth.WebApi.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string? Email { get; set; }
        public string? Alias { get; set; }
        public string? Contraseña { get; set; }
        public int RolId { get; set; }
    }
}