using System;

namespace Actividad2
{
    partial class FormMenuArticulo
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.DETALLES = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnModificarArticulo = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBorrarArticulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtrasMarcaMenuArticulo = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DETALLES});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(115, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(589, 345);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // DETALLES
            // 
            this.DETALLES.Text = "ID Articulo";
            this.DETALLES.Width = 266;
            // 
            // BtnModificarArticulo
            // 
            this.BtnModificarArticulo.Image = global::Actividad2.Properties.Resources.icons8_modificar_16;
            this.BtnModificarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarArticulo.Location = new System.Drawing.Point(555, 12);
            this.BtnModificarArticulo.Name = "BtnModificarArticulo";
            this.BtnModificarArticulo.Size = new System.Drawing.Size(77, 37);
            this.BtnModificarArticulo.TabIndex = 18;
            this.BtnModificarArticulo.Text = "Modificar";
            this.BtnModificarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificarArticulo.UseVisualStyleBackColor = true;
            this.BtnModificarArticulo.Click += new System.EventHandler(this.BtnModificarArticulo_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(241, 67);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(511, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Busqueda Avanzada";
            // 
            // BtnBorrarArticulo
            // 
            this.BtnBorrarArticulo.Image = global::Actividad2.Properties.Resources.multiply;
            this.BtnBorrarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrarArticulo.Location = new System.Drawing.Point(638, 12);
            this.BtnBorrarArticulo.Name = "BtnBorrarArticulo";
            this.BtnBorrarArticulo.Size = new System.Drawing.Size(66, 37);
            this.BtnBorrarArticulo.TabIndex = 16;
            this.BtnBorrarArticulo.Text = "Borrar";
            this.BtnBorrarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBorrarArticulo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese Nombre";
            // 
            // btnAtrasMarcaMenuArticulo
            // 
            this.btnAtrasMarcaMenuArticulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtrasMarcaMenuArticulo.Image = global::Actividad2.Properties.Resources.icons8_atrás_161;
            this.btnAtrasMarcaMenuArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasMarcaMenuArticulo.Location = new System.Drawing.Point(29, 393);
            this.btnAtrasMarcaMenuArticulo.Name = "btnAtrasMarcaMenuArticulo";
            this.btnAtrasMarcaMenuArticulo.Size = new System.Drawing.Size(59, 32);
            this.btnAtrasMarcaMenuArticulo.TabIndex = 19;
            this.btnAtrasMarcaMenuArticulo.Text = "Atras";
            this.btnAtrasMarcaMenuArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtrasMarcaMenuArticulo.UseVisualStyleBackColor = true;
            this.btnAtrasMarcaMenuArticulo.Click += new System.EventHandler(this.btnAtrasMarcaMenuArticulo_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.BackColor = System.Drawing.SystemColors.Control;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Image = global::Actividad2.Properties.Resources.lupa;
            this.searchButton.Location = new System.Drawing.Point(367, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(23, 21);
            this.searchButton.TabIndex = 20;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // FormMenuArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.btnAtrasMarcaMenuArticulo);
            this.Controls.Add(this.BtnModificarArticulo);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBorrarArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuArticulo";
            this.Text = "MenuArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAtrasListaArticulo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DETALLES;
        private System.Windows.Forms.Button BtnModificarArticulo;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBorrarArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtrasMarcaMenuArticulo;
        private System.Windows.Forms.Button searchButton;
    }
}