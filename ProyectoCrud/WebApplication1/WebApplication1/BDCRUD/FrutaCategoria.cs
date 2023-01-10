using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.BDCRUD;

[Table("fruta_categorias")]
public partial class FrutaCategoria
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [InverseProperty("IdFrutaCategoriaNavigation")]
    public virtual ICollection<Fruta> Fruta { get; } = new List<Fruta>();
}
