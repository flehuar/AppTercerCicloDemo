using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductoResponse
    {
        public int Id { get; set; }
        public int? IdCategoria { get; set; }
        [StringLength(50)]
        public string? Nombre { get; set; }
        /// <summary>
        /// 00000,000
        /// </summary>
        [Column(TypeName = "decimal(8, 3)")]
        public decimal? Stock { get; set; }
        public bool? Estado { get; set; }
    }
}
