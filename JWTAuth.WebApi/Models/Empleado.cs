namespace JWTAuth.WebApi.Models
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string? Genero { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public int UsuarioID { get; set; }
    }
}