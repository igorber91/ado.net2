namespace WindowsFormsApp6
{
    partial class ventas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btVenta = new System.Windows.Forms.Button();
            this.btFinalizarVenta = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lbIdVenta = new System.Windows.Forms.ListBox();
            this.lblCompra = new System.Windows.Forms.ListBox();
            this.lblPrecios = new System.Windows.Forms.ListBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btCliente = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mostrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventas2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1017, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carro Compra";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(716, 665);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(713, 529);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "idVenta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(713, 615);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "fechaVenta";
            // 
            // btVenta
            // 
            this.btVenta.Location = new System.Drawing.Point(867, 574);
            this.btVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btVenta.Name = "btVenta";
            this.btVenta.Size = new System.Drawing.Size(100, 28);
            this.btVenta.TabIndex = 40;
            this.btVenta.Text = "btVenta";
            this.btVenta.UseVisualStyleBackColor = true;
            this.btVenta.Click += new System.EventHandler(this.btVenta_Click);
            // 
            // btFinalizarVenta
            // 
            this.btFinalizarVenta.Location = new System.Drawing.Point(1008, 487);
            this.btFinalizarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btFinalizarVenta.Name = "btFinalizarVenta";
            this.btFinalizarVenta.Size = new System.Drawing.Size(133, 32);
            this.btFinalizarVenta.TabIndex = 41;
            this.btFinalizarVenta.Text = "Finalizar Venta";
            this.btFinalizarVenta.UseVisualStyleBackColor = true;
            this.btFinalizarVenta.Click += new System.EventHandler(this.btFinalizarVenta_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(1130, 40);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 17);
            this.lblUsuario.TabIndex = 42;
            this.lblUsuario.Text = "usuario";
            // 
            // lbIdVenta
            // 
            this.lbIdVenta.FormattingEnabled = true;
            this.lbIdVenta.ItemHeight = 16;
            this.lbIdVenta.Location = new System.Drawing.Point(698, 566);
            this.lbIdVenta.Name = "lbIdVenta";
            this.lbIdVenta.Size = new System.Drawing.Size(120, 36);
            this.lbIdVenta.TabIndex = 44;
            // 
            // lblCompra
            // 
            this.lblCompra.FormattingEnabled = true;
            this.lblCompra.ItemHeight = 16;
            this.lblCompra.Location = new System.Drawing.Point(255, 438);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(145, 164);
            this.lblCompra.TabIndex = 45;
            // 
            // lblPrecios
            // 
            this.lblPrecios.FormattingEnabled = true;
            this.lblPrecios.ItemHeight = 16;
            this.lblPrecios.Location = new System.Drawing.Point(441, 438);
            this.lblPrecios.Name = "lblPrecios";
            this.lblPrecios.Size = new System.Drawing.Size(145, 164);
            this.lblPrecios.TabIndex = 46;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(441, 628);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 49;
            // 
            // btCliente
            // 
            this.btCliente.Location = new System.Drawing.Point(1072, 81);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(141, 27);
            this.btCliente.TabIndex = 50;
            this.btCliente.Text = "Mostrar Cliente";
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(1094, 137);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(42, 17);
            this.lblSaldo.TabIndex = 51;
            this.lblSaldo.Text = "saldo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarClienteToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.ventas2ToolStripMenuItem,
            this.insertarProductoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1261, 28);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mostrarClienteToolStripMenuItem
            // 
            this.mostrarClienteToolStripMenuItem.Name = "mostrarClienteToolStripMenuItem";
            this.mostrarClienteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.mostrarClienteToolStripMenuItem.Text = "Mostrar Cliente";
            this.mostrarClienteToolStripMenuItem.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.btVentas_Click);
            // 
            // ventas2ToolStripMenuItem
            // 
            this.ventas2ToolStripMenuItem.Name = "ventas2ToolStripMenuItem";
            this.ventas2ToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ventas2ToolStripMenuItem.Text = "Ventas2";
            this.ventas2ToolStripMenuItem.Click += new System.EventHandler(this.btVentas2_Click);
            // 
            // insertarProductoToolStripMenuItem
            // 
            this.insertarProductoToolStripMenuItem.Name = "insertarProductoToolStripMenuItem";
            this.insertarProductoToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.insertarProductoToolStripMenuItem.Text = "Insertar Producto";
            this.insertarProductoToolStripMenuItem.Click += new System.EventHandler(this.btInsertarProductos_Click);
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 784);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btCliente);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecios);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.lbIdVenta);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btFinalizarVenta);
            this.Controls.Add(this.btVenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ventas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btVenta;
        private System.Windows.Forms.Button btFinalizarVenta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ListBox lbIdVenta;
        private System.Windows.Forms.ListBox lblCompra;
        private System.Windows.Forms.ListBox lblPrecios;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventas2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarProductoToolStripMenuItem;
    }
}

