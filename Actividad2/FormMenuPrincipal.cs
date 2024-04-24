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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormAgregarArticulo))
                    return;
            }

            FormAgregarArticulo ventanaAA = new FormAgregarArticulo();
            ventanaAA.MdiParent = this;
            ventanaAA.Show();
            ventanaAA.Dock = DockStyle.Fill;
            ventanaAA.TopLevel = false;
        }


        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuListaMarca_Click(object sender, EventArgs e)
        {
            FormListadoMarca VentanaListadoMarca = new FormListadoMarca();
            VentanaListadoMarca.MdiParent = this;
            VentanaListadoMarca.Show();
            VentanaListadoMarca.Dock = DockStyle.Fill;
            VentanaListadoMarca.TopLevel = false;
        }
    }
}
