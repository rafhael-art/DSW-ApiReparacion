using ApiReparacion.Models;

namespace ApiReparacion.Repository
{
    public interface IDetalleReparacionRepository
    {
        public Task<DetalleReparacion> CreateDetalle(DetalleReparacion detalle);
        public Task<DetalleReparacion> GetDetalleById(int id);
        public Task<ICollection<DetalleReparacion>> GetDetalles();
        public Task<ICollection<DetalleReparacion>> GetDetallesByReparacionId(int idRep);
        public Task<DetalleReparacion> UpdateDetalle(DetalleReparacion detalle);
        public Task<bool> DeleteDetalle(int id);
    }
}
