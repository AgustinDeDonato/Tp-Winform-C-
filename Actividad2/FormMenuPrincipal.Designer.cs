namespace Actividad2
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnMenuArticulos = new System.Windows.Forms.Button();
            this.btnMenuMarcas = new System.Windows.Forms.Button();
            this.btnMenuCategorias = new System.Windows.Forms.Button();
            this.msgAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(40, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(238, 25);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Campos gestionables";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMenuArticulos
            // 
            this.btnMenuArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMenuArticulos.AutoSize = true;
            this.btnMenuArticulos.Location = new System.Drawing.Point(120, 71);
            this.btnMenuArticulos.Name = "btnMenuArticulos";
            this.btnMenuArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnMenuArticulos.TabIndex = 1;
            this.btnMenuArticulos.Text = "Articulos";
            this.msgAyuda.SetToolTip(this.btnMenuArticulos, "·Crear Articulos\r\n·Modificar Articulos\r\n·Borrar Articulos\r\n·Listar Articulos\r\n·Bu" +
        "squeda de Articulos");
            this.btnMenuArticulos.UseVisualStyleBackColor = true;
            this.btnMenuArticulos.Click += new System.EventHandler(this.btnMenuArticulos_Click);
            // 
            // btnMenuMarcas
            // 
            this.btnMenuMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMenuMarcas.Location = new System.Drawing.Point(120, 112);
            this.btnMenuMarcas.Name = "btnMenuMarcas";
            this.btnMenuMarcas.Size = new System.Drawing.Size(75, 23);
            this.btnMenuMarcas.TabIndex = 2;
            this.btnMenuMarcas.Text = "Marcas";
            this.msgAyuda.SetToolTip(this.btnMenuMarcas, "·Crear Marcas\r\n·Modificar Marcas\r\n·Listar Marcas\r\n·Busqueda de Marcas\r\n");
            this.btnMenuMarcas.UseVisualStyleBackColor = true;
            // 
            // btnMenuCategorias
            // 
            this.btnMenuCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMenuCategorias.Location = new System.Drawing.Point(120, 153);
            this.btnMenuCategorias.Name = "btnMenuCategorias";
            this.btnMenuCategorias.Size = new System.Drawing.Size(75, 23);
            this.btnMenuCategorias.TabIndex = 3;
            this.btnMenuCategorias.Text = "Categorias";
            this.msgAyuda.SetToolTip(this.btnMenuCategorias, "·Crear Categorias\r\n·Modificar Categorias\r\n·Listar Categorias\r\n·Busqueda de Catego" +
        "rias\r\n");
            this.btnMenuCategorias.UseVisualStyleBackColor = true;
            // 
            // msgAyuda
            // 
            this.msgAyuda.AutomaticDelay = 800;
            this.msgAyuda.AutoPopDelay = 5000;
            this.msgAyuda.InitialDelay = 800;
            this.msgAyuda.ReshowDelay = 160;
            this.msgAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.msgAyuda.ToolTipTitle = "Funciones";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(314, 240);
            this.Controls.Add(this.btnMenuCategorias);
            this.Controls.Add(this.btnMenuMarcas);
            this.Controls.Add(this.btnMenuArticulos);
            this.Controls.Add(this.Titulo);
            this.MaximumSize = new System.Drawing.Size(330, 279);
            this.MinimumSize = new System.Drawing.Size(330, 279);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de catalogos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnMenuArticulos;
        private System.Windows.Forms.Button btnMenuMarcas;
        private System.Windows.Forms.Button btnMenuCategorias;
        private System.Windows.Forms.ToolTip msgAyuda;
    }
}

