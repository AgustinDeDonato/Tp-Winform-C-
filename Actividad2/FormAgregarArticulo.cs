using Dominios;
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
    public partial class FormAgregarArticulo : Form
    {
        public FormAgregarArticulo()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocioArt = new ArticuloNegocio();

            try
            {
                nuevo.nombre = textBoxNombre.Text;
                nuevo.codigo = textBoxCodigo.Text;
                nuevo.descripcion = textBoxDescripcion.Text;
                try
                {
                   nuevo.precio = Decimal.Parse(textBoxPrecio.Text);
                }
                catch
                {

                    nuevo.precio = 0;
                }         
                nuevo.marca = (Marca)comboBoxMarca.SelectedItem;
                nuevo.categoria = (Categoria)comboBoxCat.SelectedItem;

                negocioArt.agregar(nuevo);
                MessageBox.Show("agregado exitosamente");

                comboBoxMarca.SelectedIndex = -1;
                comboBoxCat.SelectedIndex = -1;
                textBoxNombre.Text = null;
                textBoxCodigo .Text = null;
                textBoxDescripcion .Text = null;
                textBoxPrecio .Text = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCat = new CategoriaNegocio();
            try
            {
                comboBoxMarca.DataSource = negocioMarca.listar();
                comboBoxCat.DataSource = negocioCat.listar();
                comboBoxMarca.SelectedIndex = -1;
                comboBoxCat.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
