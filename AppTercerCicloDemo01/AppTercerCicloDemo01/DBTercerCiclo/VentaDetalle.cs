using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AppTercerCicloDemo01.DBTercerCiclo;

[Table("Venta_detalle")]
public partial class VentaDetalle
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("id_Venta")]
    public long? IdVenta { get; set; }

    [Column("Fecha_Venta", TypeName = "datetime")]
    public DateTime? FechaVenta { get; set; }

    [Column("id_categoria")]
    public int? IdCategoria { get; set; }

    [Column("id_producto")]
    public int? IdProducto { get; set; }

    [Column("monto_producto_sin_igv", TypeName = "decimal(8, 3)")]
    public decimal? MontoProductoSinIgv { get; set; }

    [Column("monto_producto_con_igv", TypeName = "decimal(8, 3)")]
    public decimal? MontoProductoConIgv { get; set; }

    [Column("cantidad", TypeName = "decimal(8, 3)")]
    public decimal? Cantidad { get; set; }

    [Column("id_venta_estado")]
    public int? IdVentaEstado { get; set; }

    [ForeignKey("IdCategoria")]
    [InverseProperty("VentaDetalles")]
    public virtual Categorium? IdCategoriaNavigation { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("VentaDetalles")]
    public virtual Producto? IdProductoNavigation { get; set; }

    [ForeignKey("IdVentaEstado")]
    [InverseProperty("VentaDetalles")]
    public virtual VentaEstado? IdVentaEstadoNavigation { get; set; }

    [ForeignKey("IdVenta")]
    [InverseProperty("VentaDetalles")]
    public virtual Ventum? IdVentaNavigation { get; set; }
}
