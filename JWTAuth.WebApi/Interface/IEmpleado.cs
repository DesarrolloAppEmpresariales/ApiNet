using JWTAuth.WebApi.Models;

namespace JWTAuth.WebApi.Interface
{
    public interface IEmpleado
    {
        public List<Empleado> ObtenerListaEmpleados();
        public Empleado ObtenerEmpleadoPorId(int id);
        public void CrearEmpleado(Empleado empleado);
        public void ActualizarEmpleado(Empleado empleado);
        public Empleado EliminarEmpleado(int id);
        public bool ValidarEmpleado(int id);
    }
}