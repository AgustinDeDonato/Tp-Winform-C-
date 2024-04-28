using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominios;
using Negocios;
namespace WindowsForms
{
    public partial class FormMenuArticulo : Form
    {
        private List<Articulo> ListaArticulo;
        public FormMenuArticulo()
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
            //Muestra la ventana y no se va a cerrar hasta que se finalice de usar
            modificarArticulo.ShowDialog();
        }

        private void btnAtrasMarcaMenuArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBorrarArticulo_Click_1(object sender, EventArgs e)
        {
            //Llamado ventana Eliminar Articulo
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormEliminarArticulo))

                    return;
            }
            FormEliminarArticulo eliminarArticulo = new FormEliminarArticulo();

            eliminarArticulo.ShowDialog();
        }

        private void FormMenuArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulo = negocio.listar();
            dgvArticulos.DataSource = ListaArticulo;
            dgvArticulos.Columns["imagen"].Visible = false;
            CargarImagen(ListaArticulo[0].imagen.Url);
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Codigo");
            comboBoxCampo.Items.Add("Descripción");
            comboBoxCampo.Items.Add("Marca");
            comboBoxCampo.Items.Add("Categoria");
            comboBoxCampo.Items.Add("Precio");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.imagen.Url);

            Marca mar = new Marca();
            mar.ToString();

            Categoria cat = new Categoria();
            cat.ToString();
        }
        private void CargarImagen(string imagen)
        {
            try
            {
               pbxArticulo.Load(imagen);
            }
            catch(Exception ex)
            {
                pbxArticulo.Load("https://cdn.icon-icons.com/icons2/3001/PNG/512/default_filetype_file_empty_document_icon_187718.png");
            }
        }

        private void searchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            string filtro = searchTextBox.Text;
            listaFiltrada = ListaArticulo.FindAll(x => x.nombre.ToUpper().Contains(filtro.ToUpper()));
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
        }

        private void comboBoxCampo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Empieza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAvanzado.Text;
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Motor de busqueda para el listbox 
        // Funcionalidad dormida hasta no tener colleccion de articulos
        /*
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchName = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchName))
            {
                int index = listView1.FindItemWithText(searchName);
                if (index != ListBox.NoMatches)
                {
                    listView1.SelectedIndices= index;
                }
                else
                {
                    MessageBox.Show($"Name '{searchName}' not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a name to search.");
            }
        */
    }
        
     

    }
