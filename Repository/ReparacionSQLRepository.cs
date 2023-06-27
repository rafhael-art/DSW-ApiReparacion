using ApiReparacion.DbContexts;
using ApiReparacion.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiReparacion.Repository
{
    public class ReparacionSQLRepository : IReparacionRepository
    {
        AppDbContext dbContext;
        public ReparacionSQLRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Reparacion> CreateReparacion(Reparacion reparacion)
        {
            dbContext.reparacion.Add(reparacion);
            await dbContext.SaveChangesAsync();
            return reparacion;
        }

        public async Task<bool> DeleteReparacion(int id)
        {
            var rs = await dbContext.reparacion.FirstOrDefaultAsync(r => r.idReparacion == id); ;
            if (rs == null)
            {
                return false;
            }
            dbContext.reparacion.Remove(rs);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Reparacion> GetReparacionById(int id)
        {
            var rs = await dbContext.reparacion.FirstOrDefaultAsync(r => r.idReparacion==id);
            if (rs == null)
            {
                throw new Exception();
            }
            await dbContext.SaveChangesAsync();
            return rs;
        }

        public async Task<ICollection<Reparacion>> GetReparaciones()
        {
            var rs = await dbContext.reparacion.ToListAsync();

            return rs;
        }

        public async Task<Reparacion> UpdateReparacion(Reparacion reparacion)
        {
            dbContext.reparacion.Update(reparacion);
            await dbContext.SaveChangesAsync();

            var reparaciones = reparacion.detalles.ToList();
            var reparacionesANT = await dbContext.detalleReparacion.Where(x => x.reparacionId == reparacion.idReparacion).ToListAsync();
            reparacionesANT.ForEach(x => {
                if (!reparaciones.Exists(y => y.idDetalle == x.idDetalle)) {
                    dbContext.detalleReparacion.Remove(x);
                }
            });
            await dbContext.SaveChangesAsync();
            return reparacion;
        }
    }
}
