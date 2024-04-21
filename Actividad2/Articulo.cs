using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    class Articulo
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }
        public List<Imagen> imagen { get; set; }
        public double precio {  get; set; }
        public   bool estado { get; set; }
    }
}
