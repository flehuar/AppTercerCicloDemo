using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.BDCRUD;

[Table("menu")]
public partial class Menu
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string? Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("icon")]
    public string? Icon { get; set; }

    [Column("datatarget")]
    public string? Datatarget { get; set; }

    [Column("url")]
    public string? Url { get; set; }

    [Column("padre")]
    public int Padre { get; set; }

    [Column("id_status")]
    public short IdStatus { get; set; }

    [InverseProperty("IdMenuNavigation")]
    public virtual ICollection<MenuRole> MenuRoles { get; } = new List<MenuRole>();
}
