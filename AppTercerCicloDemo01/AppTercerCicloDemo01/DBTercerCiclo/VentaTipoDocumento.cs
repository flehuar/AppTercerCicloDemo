using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AppTercerCicloDemo01.DBTercerCiclo;

[Table("Venta_Tipo_Documento")]
public partial class VentaTipoDocumento
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("codigo_sunat")]
    [StringLength(3)]
    [Unicode(false)]
    public string CodigoSunat { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column("estado")]
    public bool? Estado { get; set; }

    [InverseProperty("IdVentaTipoDocumentoNavigation")]
    public virtual ICollection<Ventum> Venta { get; } = new List<Ventum>();
}
