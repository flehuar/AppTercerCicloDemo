using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AppTercerCicloDemo01.DBTercerCiclo;

/// <summary>
/// Maestra de productos
/// </summary>
[Table("Producto")]
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

    [ForeignKey("IdCategoria")]
    [InverseProperty("Productos")]
    public virtual Categoria? IdCategoriaNavigation { get; set; }

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<VentaDetalle> VentaDetalles { get; } = new List<VentaDetalle>();
}
