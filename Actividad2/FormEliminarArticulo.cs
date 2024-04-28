using Dominios;
using Negocios;
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
        private void FormEliminarArticulo_Load(object sender, EventArgs e)
        {
            //Funcionalidad listado combobox
            ArticuloNegocio negocio = new ArticuloNegocio();
           
            try
            {
                comboboxArticulo.DataSource = negocio.listar();
                
                comboboxArticulo.SelectedIndex = -1;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAtrasListaMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            //Baja Fisica Marca
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)comboboxArticulo.SelectedItem;
                    negocio.eliminar(seleccionado.codigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Se ha eliminado Correctamente");
        }
    }
}

