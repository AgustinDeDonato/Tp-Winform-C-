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
    public partial class FormListadoCategoria : Form
    {
        public FormListadoCategoria()
        {
            InitializeComponent();
        }

        private void btnAtrasListaCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListadoCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormModificarCategoria))

                    return;
            }
            FormModificarCategoria modificarCategoria = new FormModificarCategoria();
            //Muestra la ventana y no se va a cerrar hasta que se finalice de usar
            modificarCategoria.ShowDialog();
        }
    }
}
