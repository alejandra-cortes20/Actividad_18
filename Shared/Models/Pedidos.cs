using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Pedidos
    {
        public int Id { get; set; }
        public string Nombre_cliente { get; set; }
        public string DireccionEntrega { get; set; }
        public string Estado { get; set; }

        public int ClientesId { get; set; }
        public virtual Clientes? Cliente { get; set; }

        public virtual ICollection<Productos>? Producto { get; set; }
    }
}
