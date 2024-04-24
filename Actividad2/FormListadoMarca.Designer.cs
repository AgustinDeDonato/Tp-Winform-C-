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
            this.listadoMarcas = new System.Windows.Forms.ListBox();
            this.lblBusquedaMarcas = new System.Windows.Forms.Label();
            this.btnAtrasListaMarca = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
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
            // listadoMarcas
            // 
            this.listadoMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listadoMarcas.FormattingEnabled = true;
            this.listadoMarcas.Location = new System.Drawing.Point(41, 82);
            this.listadoMarcas.Name = "listadoMarcas";
            this.listadoMarcas.Size = new System.Drawing.Size(698, 303);
            this.listadoMarcas.TabIndex = 1;
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
            // FormListadoMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtrasListaMarca);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.lblBusquedaMarcas);
            this.Controls.Add(this.listadoMarcas);
            this.Controls.Add(this.txtBusquedaMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListadoMarca";
            this.Text = "FormListadoMarca";
            this.Load += new System.EventHandler(this.FormListadoMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedaMarca;
        private System.Windows.Forms.ListBox listadoMarcas;
        private System.Windows.Forms.Label lblBusquedaMarcas;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnAtrasListaMarca;
    }
}