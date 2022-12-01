using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.DBTercerCiclo;

/// <summary>
/// Maestra de productos
/// </summary>
[Table("Producto")]
[Index("Codigo", Name = "UQ__Producto__06370DACF032AA3C", IsUnique = true)]
public partial class Producto
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_categoria")]
    public int? IdCategoria { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    /// <summary>
    /// 00000,000
    /// </summary>
    [Column(TypeName = "decimal(8, 3)")]
    public decimal? Stock { get; set; }

    [Column("estado")]
    public bool? Estado { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [ForeignKey("IdCategoria")]
    [InverseProperty("Productos")]
    public virtual Categoria? IdCategoriaNavigation { get; set; }

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<VentaDetalle> VentaDetalles { get; } = new List<VentaDetalle>();
}
