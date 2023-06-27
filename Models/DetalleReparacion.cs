using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ApiReparacion.Models
{
    public class DetalleReparacion
    {
        [Key]
        public int idDetalle { get; set; }
        [Required]
        public string? nombre { get; set; }
        [Required]
        [NotNull]
        [DefaultValue(0)]
        public int cantidad { get; set; }
        [Required]
        public double precioUnitario { get; set; }
        [Required]
        [DefaultValue(0)]
        public double igv { get; set; }
        [Required]
        [DefaultValue(0)]
        public double subtotal { get; set; }
        [Required]
        public int reparacionId { get; set; }
        public Reparacion? reparacion { get; set; }
    }
}
