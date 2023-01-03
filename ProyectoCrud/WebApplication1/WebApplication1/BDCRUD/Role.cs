using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.BDCRUD;

[Table("role")]
public partial class Role
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("description")]
    [StringLength(255)]
    public string? Description { get; set; }

    [Column("function")]
    public string? Function { get; set; }

    [Column("id_status")]
    public short IdStatus { get; set; }

    [InverseProperty("IdRoleNavigation")]
    public virtual ICollection<MenuRole> MenuRoles { get; } = new List<MenuRole>();

    [InverseProperty("IdRoleNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
