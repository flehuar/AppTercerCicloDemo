using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.DBTercerCiclo;

public partial class Categoria
{
    [Key]
    public int Id { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    /// <summary>
    /// 0 ==&gt; false | 1 ==&gt; true
    /// </summary>
    [Column("estado")]
    public bool? Estado { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [InverseProperty("IdCategoriaNavigation")]
    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();

    [InverseProperty("IdCategoriaNavigation")]
    public virtual ICollection<VentaDetalle> VentaDetalles { get; } = new List<VentaDetalle>();
}
