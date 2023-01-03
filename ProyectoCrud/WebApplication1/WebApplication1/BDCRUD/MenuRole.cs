using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.BDCRUD;

[Table("menu_role")]
public partial class MenuRole
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("id_menu")]
    public short IdMenu { get; set; }

    [Column("id_role")]
    public short IdRole { get; set; }

    [Column("id_status")]
    public short IdStatus { get; set; }

    [ForeignKey("IdMenu")]
    [InverseProperty("MenuRoles")]
    public virtual Menu IdMenuNavigation { get; set; } = null!;

    [ForeignKey("IdRole")]
    [InverseProperty("MenuRoles")]
    public virtual Role IdRoleNavigation { get; set; } = null!;
}
