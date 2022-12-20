using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.BDCRUD;

[Table("producto")]
public partial class Producto
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("categoria")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Categoria { get; set; }

    [Column("nombre")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("stock", TypeName = "decimal(10, 3)")]
    public decimal? Stock { get; set; }

    [Column("fecha_vencimiento", TypeName = "datetime")]
    public DateTime? FechaVencimiento { get; set; }

    [Column("costo_sin_igv", TypeName = "decimal(10, 3)")]
    public decimal? CostoSinIgv { get; set; }

    [Column("costo_con_igv", TypeName = "decimal(10, 3)")]
    public decimal? CostoConIgv { get; set; }
}
