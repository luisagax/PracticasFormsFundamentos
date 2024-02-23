
namespace TicketDeVentaP1
{
    partial class frmCompras
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
            this.libSubtotal = new System.Windows.Forms.ListBox();
            this.btnAgr = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // libSubtotal
            // 
            this.libSubtotal.FormattingEnabled = true;
            this.libSubtotal.ItemHeight = 22;
            this.libSubtotal.Location = new System.Drawing.Point(76, 112);
            this.libSubtotal.Name = "libSubtotal";
            this.libSubtotal.Size = new System.Drawing.Size(437, 180);
            this.libSubtotal.TabIndex = 17;
            // 
            // btnAgr
            // 
            this.btnAgr.Location = new System.Drawing.Point(449, 78);
            this.btnAgr.Name = "btnAgr";
            this.btnAgr.Size = new System.Drawing.Size(64, 28);
            this.btnAgr.TabIndex = 16;
            this.btnAgr.Text = "+";
            this.btnAgr.UseVisualStyleBackColor = true;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(333, 78);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 28);
            this.txtCant.TabIndex = 15;
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(76, 78);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(235, 28);
            this.txtArt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "CANT.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "ARTÍCULOS";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(585, 334);
            this.Controls.Add(this.libSubtotal);
            this.Controls.Add(this.btnAgr);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tw Cen MT", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox libSubtotal;
        private System.Windows.Forms.Button btnAgr;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}