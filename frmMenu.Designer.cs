
namespace TicketDeVentaP1
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbArticulos = new System.Windows.Forms.ToolStripButton();
            this.tsbCantidad = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbArticulos,
            this.tsbCantidad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(547, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbArticulos
            // 
            this.tsbArticulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbArticulos.Image = ((System.Drawing.Image)(resources.GetObject("tsbArticulos.Image")));
            this.tsbArticulos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbArticulos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbArticulos.Name = "tsbArticulos";
            this.tsbArticulos.Size = new System.Drawing.Size(36, 36);
            this.tsbArticulos.Text = "Cargar Articulos";
            this.tsbArticulos.Click += new System.EventHandler(this.tsbArticulos_Click);
            // 
            // tsbCantidad
            // 
            this.tsbCantidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCantidad.Image = ((System.Drawing.Image)(resources.GetObject("tsbCantidad.Image")));
            this.tsbCantidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCantidad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCantidad.Name = "tsbCantidad";
            this.tsbCantidad.Size = new System.Drawing.Size(36, 36);
            this.tsbCantidad.Text = "Compras";
            this.tsbCantidad.Click += new System.EventHandler(this.tsbCantidad_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(547, 280);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmMenu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbArticulos;
        private System.Windows.Forms.ToolStripButton tsbCantidad;
    }
}