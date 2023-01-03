using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.BDCRUD;

[Table("Usuario")]
[Index("Username", Name = "UQ__Usuario__F3DBC57280334E07", IsUnique = true)]
public partial class Usuario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FullName { get; set; }

    [Column("username")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Username { get; set; }

    [Column("password")]
    [StringLength(300)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column("changed_password")]
    public bool? ChangedPassword { get; set; }

    [Column("date_changed_password", TypeName = "datetime")]
    public DateTime? DateChangedPassword { get; set; }

    [Column("last_date_login", TypeName = "datetime")]
    public DateTime? LastDateLogin { get; set; }

    [Column("id_role")]
    public short? IdRole { get; set; }

    [ForeignKey("IdRole")]
    [InverseProperty("Usuarios")]
    public virtual Role? IdRoleNavigation { get; set; }
}
