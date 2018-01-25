namespace WindowsFormsApp6
{
    partial class sesion4
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
            this.button1 = new System.Windows.Forms.Button();
            this.btInsertarProductos = new System.Windows.Forms.Button();
            this.btVentas = new System.Windows.Forms.Button();
            this.btGastado = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actualizarDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verGastadoPorClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "actualizarDepartamentos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btInsertarProductos
            // 
            this.btInsertarProductos.Location = new System.Drawing.Point(277, 186);
            this.btInsertarProductos.Name = "btInsertarProductos";
            this.btInsertarProductos.Size = new System.Drawing.Size(163, 45);
            this.btInsertarProductos.TabIndex = 1;
            this.btInsertarProductos.Text = "insertar productos";
            this.btInsertarProductos.UseVisualStyleBackColor = true;
            this.btInsertarProductos.Click += new System.EventHandler(this.btInsertarProductos_Click);
            // 
            // btVentas
            // 
            this.btVentas.Location = new System.Drawing.Point(525, 186);
            this.btVentas.Name = "btVentas";
            this.btVentas.Size = new System.Drawing.Size(173, 45);
            this.btVentas.TabIndex = 2;
            this.btVentas.Text = "ver ventas";
            this.btVentas.UseVisualStyleBackColor = true;
            this.btVentas.Click += new System.EventHandler(this.btVentas_Click);
            // 
            // btGastado
            // 
            this.btGastado.Location = new System.Drawing.Point(277, 353);
            this.btGastado.Name = "btGastado";
            this.btGastado.Size = new System.Drawing.Size(180, 45);
            this.btGastado.TabIndex = 3;
            this.btGastado.Text = "Ver gastado por clientes";
            this.btGastado.UseVisualStyleBackColor = true;
            this.btGastado.Click += new System.EventHandler(this.btGastado_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarDepartamentosToolStripMenuItem,
            this.insertarProductosToolStripMenuItem,
            this.verVentasToolStripMenuItem,
            this.verGastadoPorClientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actualizarDepartamentosToolStripMenuItem
            // 
            this.actualizarDepartamentosToolStripMenuItem.Name = "actualizarDepartamentosToolStripMenuItem";
            this.actualizarDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.actualizarDepartamentosToolStripMenuItem.Text = "actualizarDepartamentos";
            this.actualizarDepartamentosToolStripMenuItem.Click += new System.EventHandler(this.actualizarDepartamentosToolStripMenuItem_Click);
            // 
            // insertarProductosToolStripMenuItem
            // 
            this.insertarProductosToolStripMenuItem.Name = "insertarProductosToolStripMenuItem";
            this.insertarProductosToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.insertarProductosToolStripMenuItem.Text = "insertar productos";
            this.insertarProductosToolStripMenuItem.Click += new System.EventHandler(this.insertarProductosToolStripMenuItem_Click);
            // 
            // verVentasToolStripMenuItem
            // 
            this.verVentasToolStripMenuItem.Name = "verVentasToolStripMenuItem";
            this.verVentasToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.verVentasToolStripMenuItem.Text = "ver ventas";
            this.verVentasToolStripMenuItem.Click += new System.EventHandler(this.verVentasToolStripMenuItem_Click);
            // 
            // verGastadoPorClientesToolStripMenuItem
            // 
            this.verGastadoPorClientesToolStripMenuItem.Name = "verGastadoPorClientesToolStripMenuItem";
            this.verGastadoPorClientesToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.verGastadoPorClientesToolStripMenuItem.Text = "Ver gastado por clientes";
            this.verGastadoPorClientesToolStripMenuItem.Click += new System.EventHandler(this.verGastadoPorClientesToolStripMenuItem_Click);
            // 
            // sesion4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 509);
            this.Controls.Add(this.btGastado);
            this.Controls.Add(this.btVentas);
            this.Controls.Add(this.btInsertarProductos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sesion4";
            this.Text = "sesion4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btInsertarProductos;
        private System.Windows.Forms.Button btVentas;
        private System.Windows.Forms.Button btGastado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualizarDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verGastadoPorClientesToolStripMenuItem;
    }
}