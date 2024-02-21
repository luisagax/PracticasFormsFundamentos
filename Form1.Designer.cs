
namespace TicketDeVentaP1
{
    partial class frmTicketVenta
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
            this.libArticulos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.libSubtotal = new System.Windows.Forms.ListBox();
            this.btnAgr = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // libArticulos
            // 
            this.libArticulos.FormattingEnabled = true;
            this.libArticulos.ItemHeight = 22;
            this.libArticulos.Location = new System.Drawing.Point(30, 89);
            this.libArticulos.Name = "libArticulos";
            this.libArticulos.Size = new System.Drawing.Size(437, 180);
            this.libArticulos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARTÍCULOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRECIO";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(30, 55);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(235, 28);
            this.txtArticulo.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(287, 55);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 28);
            this.txtPrecio.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(403, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(64, 28);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // libSubtotal
            // 
            this.libSubtotal.FormattingEnabled = true;
            this.libSubtotal.ItemHeight = 22;
            this.libSubtotal.Location = new System.Drawing.Point(548, 89);
            this.libSubtotal.Name = "libSubtotal";
            this.libSubtotal.Size = new System.Drawing.Size(437, 180);
            this.libSubtotal.TabIndex = 11;
            // 
            // btnAgr
            // 
            this.btnAgr.Location = new System.Drawing.Point(921, 55);
            this.btnAgr.Name = "btnAgr";
            this.btnAgr.Size = new System.Drawing.Size(64, 28);
            this.btnAgr.TabIndex = 10;
            this.btnAgr.Text = "+";
            this.btnAgr.UseVisualStyleBackColor = true;
            this.btnAgr.Click += new System.EventHandler(this.btnAgr_Click);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(805, 55);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 28);
            this.txtCant.TabIndex = 9;
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(548, 55);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(235, 28);
            this.txtArt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(801, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "CANT.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "ARTÍCULOS";
            // 
            // frmTicketVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1047, 320);
            this.Controls.Add(this.libSubtotal);
            this.Controls.Add(this.btnAgr);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.libArticulos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmTicketVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TICKET DE VENTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox libArticulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox libSubtotal;
        private System.Windows.Forms.Button btnAgr;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

