namespace Lab.Net.EF.LINQ.UI.Presentacion
{
    partial class Consulta7
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
            this.dgvPedidoDeCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoDeCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidoDeCliente
            // 
            this.dgvPedidoDeCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidoDeCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoDeCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidoDeCliente.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidoDeCliente.Name = "dgvPedidoDeCliente";
            this.dgvPedidoDeCliente.Size = new System.Drawing.Size(800, 450);
            this.dgvPedidoDeCliente.TabIndex = 4;
            // 
            // Consulta7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPedidoDeCliente);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Consulta7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedidos de Clientes";
            this.Load += new System.EventHandler(this.Consulta7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoDeCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidoDeCliente;
    }
}