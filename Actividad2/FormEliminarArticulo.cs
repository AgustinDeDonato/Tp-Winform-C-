using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms 
{
    public partial class FormEliminarArticulo : Form
    {
        public FormEliminarArticulo()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            //Baja fisica&logica
            //mensaje de exito
            MessageBox.Show("Se ha eliminado Correctamente");
        }

        private void btnAtrasListaMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

