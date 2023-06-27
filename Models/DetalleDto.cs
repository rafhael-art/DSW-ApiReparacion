namespace ApiReparacion.Models
{
    public class DetalleDto
    {
        public string? nombre { get; set; }
        public int cantidad { get; set; }
        public double precioUnitario { get; set; }
        public double igv { get; set; }
        public double subtotal { get; set; }
        public int reparacionId { get; set; }
    }
}
