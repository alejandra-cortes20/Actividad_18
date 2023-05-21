using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Productos
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Ingresa un nombre valido"), MaxLength(100)]
        public string? nombre { get; set; }
        [Required(ErrorMessage = "Ingresa las tallas correspondientes")]
        public string? talla { get; set; }
        [Required(ErrorMessage = "Ingresa el precio correspondiente")]
        public int? precio { get; set; }
        public string? medidas { get; set; }

        public int? PedidosId { get; set; }
        public virtual Pedidos? Pedidos { get; set; }
    }
}
