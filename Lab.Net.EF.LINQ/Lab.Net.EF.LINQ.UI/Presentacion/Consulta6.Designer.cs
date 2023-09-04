namespace Lab.Net.EF.LINQ.UI.Presentacion
{
    partial class Consulta6
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
            this.dgvMayusculaYMinuscula = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayusculaYMinuscula)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMayusculaYMinuscula
            // 
            this.dgvMayusculaYMinuscula.AllowUserToAddRows = false;
            this.dgvMayusculaYMinuscula.AllowUserToDeleteRows = false;
            this.dgvMayusculaYMinuscula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMayusculaYMinuscula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMayusculaYMinuscula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMayusculaYMinuscula.Location = new System.Drawing.Point(0, 0);
            this.dgvMayusculaYMinuscula.Name = "dgvMayusculaYMinuscula";
            this.dgvMayusculaYMinuscula.ReadOnly = true;
            this.dgvMayusculaYMinuscula.Size = new System.Drawing.Size(800, 450);
            this.dgvMayusculaYMinuscula.TabIndex = 2;
            // 
            // Consulta6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMayusculaYMinuscula);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Consulta6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MAYUSCULA & minuscula ";
            this.Load += new System.EventHandler(this.Consulta6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayusculaYMinuscula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMayusculaYMinuscula;
    }
}