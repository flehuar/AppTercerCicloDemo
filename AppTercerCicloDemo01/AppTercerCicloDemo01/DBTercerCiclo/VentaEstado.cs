using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AppTercerCicloDemo01.DBTercerCiclo;

[Table("venta_estado")]
public partial class VentaEstado
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("descripcion")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdVentaEstadoNavigation")]
    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();

    [InverseProperty("IdVentaEstadoNavigation")]
    public virtual ICollection<VentaDetalle> VentaDetalles { get; } = new List<VentaDetalle>();
}
