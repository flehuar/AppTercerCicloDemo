using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class CategoriaRequest
    {
        public int Id { get; set; }

        [StringLength(40)] // ==> en base  de datos VARCHAR(40)
        public string? Nombre { get; set; }

        [StringLength(150)]
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }

        [StringLength(5)]
        public string? Codigo { get; set; }

        //[InverseProperty("IdCategoriaNavigation")]
        //public virtual ICollection<Producto> Productos { get; } = new List<Producto>();

        //[InverseProperty("IdCategoriaNavigation")]
        //public virtual ICollection<VentaDetalle> VentaDetalles { get; } = new List<VentaDetalle>();
    }
}