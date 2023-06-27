using ApiReparacion.Models;

namespace ApiReparacion.Repository
{
    public interface IReparacionRepository
    {
        public Task<Reparacion> CreateReparacion(Reparacion reparacion);
        public Task<Reparacion> GetReparacionById(int id);
        public Task<ICollection<Reparacion>> GetReparaciones();
        public Task<Reparacion> UpdateReparacion(Reparacion reparacion);
        public Task<bool> DeleteReparacion(int id);
    }
}
