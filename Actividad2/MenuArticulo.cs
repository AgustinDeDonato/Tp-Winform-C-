using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class MenuArticulo : Form
    {
        public MenuArticulo()
        {
            InitializeComponent();
            
        }

        private void BtnBorrarArticulo_Click(object sender, EventArgs e)
        {    
            // idea mistica(?
            // if(event aritucolo seleccion = true) {
            // }
            // get list articulo <> 
            // set estado = false; 
            // show.msg ("estas seguro?")
            // logica para borrar el articulo previamente seleccionado 

        }
        /*
        private void BtnModificarArticulo_Click(object sender, EventArgs e)
        {

        }
        */
        private void BtnModificarArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormModificarArticulo))
                    
                    return;
            }
            FormModificarArticulo modificarArticulo = new FormModificarArticulo();
            modificarArticulo.Show();
        }

        private void btnAtrasListaArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
