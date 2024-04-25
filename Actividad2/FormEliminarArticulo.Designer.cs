namespace Actividad2
{
    partial class FormEliminarArticulo
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTituloMarca = new System.Windows.Forms.Label();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAtrasListaMarca = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(267, 155);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 16);
            this.labelNombre.TabIndex = 45;
            this.labelNombre.Text = "Codigo:";
            // 
            // labelTituloMarca
            // 
            this.labelTituloMarca.AutoSize = true;
            this.labelTituloMarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTituloMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloMarca.Location = new System.Drawing.Point(289, 67);
            this.labelTituloMarca.Name = "labelTituloMarca";
            this.labelTituloMarca.Size = new System.Drawing.Size(169, 27);
            this.labelTituloMarca.TabIndex = 44;
            this.labelTituloMarca.Text = "Eliminar Articulo";
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(350, 212);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(129, 13);
            this.lblDescripcionCategoria.TabIndex = 54;
            this.lblDescripcionCategoria.Text = "aca va la descripcion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(267, 212);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 53;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(353, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 55;
            // 
            // btnAtrasListaMarca
            // 
            this.btnAtrasListaMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtrasListaMarca.Image = global::Actividad2.Properties.Resources.icons8_atrás_161;
            this.btnAtrasListaMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasListaMarca.Location = new System.Drawing.Point(54, 379);
            this.btnAtrasListaMarca.Name = "btnAtrasListaMarca";
            this.btnAtrasListaMarca.Size = new System.Drawing.Size(59, 32);
            this.btnAtrasListaMarca.TabIndex = 48;
            this.btnAtrasListaMarca.Text = "Atras";
            this.btnAtrasListaMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtrasListaMarca.UseVisualStyleBackColor = true;
            this.btnAtrasListaMarca.Click += new System.EventHandler(this.btnAtrasListaMarca_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Image = global::Actividad2.Properties.Resources.multiply;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(331, 277);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(80, 32);
            this.buttonCancelar.TabIndex = 47;
            this.buttonCancelar.Text = "Eliminar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormEliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblDescripcionCategoria);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnAtrasListaMarca);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTituloMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEliminarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtrasListaMarca;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTituloMarca;
        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}