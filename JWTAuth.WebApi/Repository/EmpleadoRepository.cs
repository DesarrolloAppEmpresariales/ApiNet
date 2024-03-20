using JWTAuth.WebApi.Interface;
using JWTAuth.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTAuth.WebApi.Repository
{
    public class EmpleadoRepository : IEmpleado
    {
        readonly DatabaseContext _dbContext = new();

        public EmpleadoRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Empleado> ObtenerListaEmpleados()
        {
            try
            {
                return _dbContext.Empleado.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Empleado ObtenerEmpleadoPorId(int id)
        {
            try
            {
                Empleado? empleado = _dbContext.Empleado.Find(id);
                if (empleado != null)
                {
                    return empleado;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public void CrearEmpleado(Empleado empleado)
        {
            try
            {
                _dbContext.Empleado.Add(empleado);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                _dbContext.Entry(empleado).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Empleado EliminarEmpleado(int id)
        {
            try
            {
                Empleado? empleado = _dbContext.Empleado.Find(id);

                if (empleado != null)
                {
                    _dbContext.Empleado.Remove(empleado);
                    _dbContext.SaveChanges();
                    return empleado;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public bool ValidarEmpleado(int id)
        {
            return _dbContext.Empleado.Any(e => e.EmpleadoID == id);
        }
    }
}