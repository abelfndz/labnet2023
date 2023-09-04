namespace Lab.Net.EF.LINQ.UI.Presentacion
{
    partial class Consulta8
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
            this.dgvClientesWa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesWa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientesWa
            // 
            this.dgvClientesWa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientesWa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesWa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientesWa.Location = new System.Drawing.Point(0, 0);
            this.dgvClientesWa.Name = "dgvClientesWa";
            this.dgvClientesWa.Size = new System.Drawing.Size(800, 450);
            this.dgvClientesWa.TabIndex = 5;
            // 
            // Consulta8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClientesWa);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Consulta8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes de WA";
            this.Load += new System.EventHandler(this.Consulta8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesWa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientesWa;
    }
}