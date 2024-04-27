using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    class Articulo
    {
        public int ID { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }
        public List<Imagen> imagen { get; set; }
        public decimal precio {  get; set; }
        //public   bool estado { get; set; }
    }
}
