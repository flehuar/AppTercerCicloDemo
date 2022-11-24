using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AppTercerCicloDemo01.DBTercerCiclo;

public partial class Ventum
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("id_Venta_Tipo_Documento")]
    public int? IdVentaTipoDocumento { get; set; }

    [Column("Numero_Serie")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NumeroSerie { get; set; }

    [Column("Numero_Documento")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NumeroDocumento { get; set; }

    [Column("Fecha_Venta", TypeName = "datetime")]
    public DateTime? FechaVenta { get; set; }

    [Column("ruc_empresa")]
    [StringLength(15)]
    [Unicode(false)]
    public string? RucEmpresa { get; set; }

    [Column("ruc_cliente")]
    [StringLength(150)]
    [Unicode(false)]
    public string? RucCliente { get; set; }

    [Column("nombre_cliente")]
    [StringLength(150)]
    [Unicode(false)]
    public string? NombreCliente { get; set; }

    [Column("Monto_Total_Sin_IGV", TypeName = "decimal(10, 3)")]
    public decimal? MontoTotalSinIgv { get; set; }

    [Column("Monto_Total_Con_IGV", TypeName = "decimal(10, 3)")]
    public decimal? MontoTotalConIgv { get; set; }

    [Column("id_venta_estado")]
    public int? IdVentaEstado { get; set; }

    [ForeignKey("IdVentaEstado")]
    [InverseProperty("Venta")]
    public virtual VentaEstado? IdVentaEstadoNavigation { get; set; }

    [ForeignKey("IdVentaTipoDocumento")]
    [InverseProperty("Venta")]
    public virtual VentaTipoDocumento? IdVentaTipoDocumentoNavigation { get; set; }

    [InverseProperty("IdVentaNavigation")]
    public virtual ICollection<VentaDetalle> VentaDetalles { get; } = new List<VentaDetalle>();
}
