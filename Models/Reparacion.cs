using System.ComponentModel.DataAnnotations;

namespace ApiReparacion.Models
{
    public class Reparacion
    {
        [Key]
        public int idReparacion { get; set; }
        public string? descripcion { get; set; }
        public int empleadoId { get; set; }
        public DateTime fecha { get; set; }
        public double total { get; set; }
        public string numero { get; set; } = null!;
        public int clienteId { get; set; }
        public ICollection<DetalleReparacion>? detalles { get; set; }
    }
}
