using ApiReparacion.DbContexts;
using ApiReparacion.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiReparacion.Repository
{
    public class DetalleSQLRepository : IDetalleReparacionRepository
    {
        AppDbContext dbContext;
        public DetalleSQLRepository(AppDbContext dbContext) { 
            this.dbContext = dbContext;
        }
        public async Task<DetalleReparacion> CreateDetalle(DetalleReparacion detalle)
        {
            dbContext.detalleReparacion.Add(detalle);
            await dbContext.SaveChangesAsync();
            return detalle;
        }

        public async Task<bool> DeleteDetalle(int id)
        {
            var rs = await dbContext.detalleReparacion.FirstOrDefaultAsync(dt=>dt.idDetalle==id);
            if (rs==null)
            {
                throw new Exception();
            }
            dbContext.detalleReparacion.Remove(rs);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<DetalleReparacion> GetDetalleById(int id)
        {
            var obj = await dbContext.detalleReparacion.FirstOrDefaultAsync(dt=>dt.idDetalle==id);
            if (obj == null)
            {
                throw new Exception();
            }
            return obj;
        }

        public async Task<ICollection<DetalleReparacion>> GetDetalles()
        {
            var list = await dbContext.detalleReparacion.ToListAsync();
            return list;
        }

        public async Task<ICollection<DetalleReparacion>> GetDetallesByReparacionId(int idRep)
        {
            var list = await dbContext.detalleReparacion.Where(dt => dt.reparacionId == idRep).ToListAsync();
            if (list == null || list.Count == 0)
            {
                throw new Exception();
            }
            return list;
        }

        public async Task<DetalleReparacion> UpdateDetalle(DetalleReparacion detalle)
        {
            dbContext.detalleReparacion.Update(detalle);
            await dbContext.SaveChangesAsync();
            return detalle;
        }
    }
}
