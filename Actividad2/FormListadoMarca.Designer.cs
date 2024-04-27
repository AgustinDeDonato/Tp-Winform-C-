namespace Actividad2
{
    partial class FormListadoMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBusquedaMarca = new System.Windows.Forms.TextBox();
            this.lblBusquedaMarcas = new System.Windows.Forms.Label();
            this.lblTituloMarca = new System.Windows.Forms.Label();
            this.btnBorrarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnAtrasListaMarca = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusquedaMarca
            // 
            this.txtBusquedaMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusquedaMarca.BackColor = System.Drawing.Color.White;
            this.txtBusquedaMarca.Location = new System.Drawing.Point(99, 44);
            this.txtBusquedaMarca.MaxLength = 500;
            this.txtBusquedaMarca.Name = "txtBusquedaMarca";
            this.txtBusquedaMarca.Size = new System.Drawing.Size(236, 20);
            this.txtBusquedaMarca.TabIndex = 0;
            // 
            // lblBusquedaMarcas
            // 
            this.lblBusquedaMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBusquedaMarcas.AutoSize = true;
            this.lblBusquedaMarcas.Location = new System.Drawing.Point(38, 48);
            this.lblBusquedaMarcas.Name = "lblBusquedaMarcas";
            this.lblBusquedaMarcas.Size = new System.Drawing.Size(40, 13);
            this.lblBusquedaMarcas.TabIndex = 2;
            this.lblBusquedaMarcas.Text = "Buscar";
            // 
            // lblTituloMarca
            // 
            this.lblTituloMarca.AutoSize = true;
            this.lblTituloMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMarca.Location = new System.Drawing.Point(3, 3);
            this.lblTituloMarca.Name = "lblTituloMarca";
            this.lblTituloMarca.Size = new System.Drawing.Size(48, 13);
            this.lblTituloMarca.TabIndex = 21;
            this.lblTituloMarca.Text = "Marcas";
            // 
            // btnBorrarMarca
            // 
            this.btnBorrarMarca.Image = global::Actividad2.Properties.Resources.multiply;
            this.btnBorrarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarMarca.Location = new System.Drawing.Point(680, 38);
            this.btnBorrarMarca.Name = "btnBorrarMarca";
            this.btnBorrarMarca.Size = new System.Drawing.Size(59, 32);
            this.btnBorrarMarca.TabIndex = 20;
            this.btnBorrarMarca.Text = "Borrar";
            this.btnBorrarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarMarca.UseVisualStyleBackColor = true;
            this.btnBorrarMarca.Click += new System.EventHandler(this.btnBorrarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Image = global::Actividad2.Properties.Resources.icons8_modificar_16;
            this.btnModificarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarMarca.Location = new System.Drawing.Point(600, 38);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(74, 32);
            this.btnModificarMarca.TabIndex = 19;
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // btnAtrasListaMarca
            // 
            this.btnAtrasListaMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtrasListaMarca.Image = global::Actividad2.Properties.Resources.icons8_atrás_161;
            this.btnAtrasListaMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasListaMarca.Location = new System.Drawing.Point(41, 399);
            this.btnAtrasListaMarca.Name = "btnAtrasListaMarca";
            this.btnAtrasListaMarca.Size = new System.Drawing.Size(59, 32);
            this.btnAtrasListaMarca.TabIndex = 18;
            this.btnAtrasListaMarca.Text = "Atras";
            this.btnAtrasListaMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtrasListaMarca.UseVisualStyleBackColor = true;
            this.btnAtrasListaMarca.Click += new System.EventHandler(this.btnCancelarListaMarca_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusqueda.Image = global::Actividad2.Properties.Resources.lupa;
            this.btnBusqueda.Location = new System.Drawing.Point(341, 44);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(23, 21);
            this.btnBusqueda.TabIndex = 3;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(41, 98);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(698, 284);
            this.dgvMarca.TabIndex = 22;
            // 
            // FormListadoMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.lblTituloMarca);
            this.Controls.Add(this.btnBorrarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnAtrasListaMarca);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.lblBusquedaMarcas);
            this.Controls.Add(this.txtBusquedaMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListadoMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListadoMarca";
            this.Load += new System.EventHandler(this.FormListadoMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedaMarca;
        private System.Windows.Forms.Label lblBusquedaMarcas;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnAtrasListaMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnBorrarMarca;
        private System.Windows.Forms.Label lblTituloMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
    }
}