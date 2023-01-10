using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.BDCRUD;

[Table("frutas")]
public partial class Fruta
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_fruta_categoria")]
    public int? IdFrutaCategoria { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [ForeignKey("IdFrutaCategoria")]
    [InverseProperty("Fruta")]
    public virtual FrutaCategoria? IdFrutaCategoriaNavigation { get; set; }
}
