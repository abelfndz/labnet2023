namespace Lab.Net.EF.LINQ.UI.Presentacion
{
    partial class Consulta12
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
            this.lblProcucto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProcucto
            // 
            this.lblProcucto.AutoSize = true;
            this.lblProcucto.Font = new System.Drawing.Font("Cascadia Code", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcucto.Location = new System.Drawing.Point(150, 212);
            this.lblProcucto.Name = "lblProcucto";
            this.lblProcucto.Size = new System.Drawing.Size(154, 49);
            this.lblProcucto.TabIndex = 1;
            this.lblProcucto.Text = "label1";
            this.lblProcucto.Visible = false;
            // 
            // Consulta12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProcucto);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Consulta12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Primer Producto";
            this.Load += new System.EventHandler(this.Consulta12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcucto;
    }
}