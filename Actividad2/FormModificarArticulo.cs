using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
namespace WindowsForms
{
    public partial class FormModificarArticulo : Form
    {
        public FormModificarArticulo()
        {
            InitializeComponent();
        }

        private void FormModificarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocioArt = new ArticuloNegocio();
            comboBox1.DataSource = negocioArt.listarNombres();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.Refresh();

            CategoriaNegocio negocioCat = new CategoriaNegocio();
            comboBoxCategoria.DataSource = negocioCat.listar();
            comboBoxCategoria.DisplayMember = "Descripcion";
            comboBoxCategoria.Refresh();

            MarcaNegocio negocioMarca = new MarcaNegocio();
            comboBoxMarca.DataSource = negocioMarca.listar();
            comboBoxMarca.DisplayMember = "Descripcion";
            comboBoxMarca.Refresh();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
