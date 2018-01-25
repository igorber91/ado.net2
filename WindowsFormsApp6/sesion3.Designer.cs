namespace WindowsFormsApp6
{
    partial class sesion3
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
            this.btVisualizarProductos = new System.Windows.Forms.Button();
            this.btVisualizarCantidades = new System.Windows.Forms.Button();
            this.btVisualizarVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCantidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btVisualizarProductos
            // 
            this.btVisualizarProductos.Location = new System.Drawing.Point(142, 116);
            this.btVisualizarProductos.Name = "btVisualizarProductos";
            this.btVisualizarProductos.Size = new System.Drawing.Size(141, 82);
            this.btVisualizarProductos.TabIndex = 0;
            this.btVisualizarProductos.Text = "visualizar productos";
            this.btVisualizarProductos.UseVisualStyleBackColor = true;
            this.btVisualizarProductos.Click += new System.EventHandler(this.btVisualizarProductos_Click);
            // 
            // btVisualizarCantidades
            // 
            this.btVisualizarCantidades.Location = new System.Drawing.Point(375, 116);
            this.btVisualizarCantidades.Name = "btVisualizarCantidades";
            this.btVisualizarCantidades.Size = new System.Drawing.Size(128, 82);
            this.btVisualizarCantidades.TabIndex = 1;
            this.btVisualizarCantidades.Text = "visualizar cantidades";
            this.btVisualizarCantidades.UseVisualStyleBackColor = true;
            this.btVisualizarCantidades.Click += new System.EventHandler(this.btVisualizarCantidades_Click);
            // 
            // btVisualizarVentas
            // 
            this.btVisualizarVentas.Location = new System.Drawing.Point(604, 116);
            this.btVisualizarVentas.Name = "btVisualizarVentas";
            this.btVisualizarVentas.Size = new System.Drawing.Size(133, 82);
            this.btVisualizarVentas.TabIndex = 2;
            this.btVisualizarVentas.Text = "visualizarVentas";
            this.btVisualizarVentas.UseVisualStyleBackColor = true;
            this.btVisualizarVentas.Click += new System.EventHandler(this.btVisualizarVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu para usuarios";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarProductosToolStripMenuItem,
            this.visualizarCantidadesToolStripMenuItem,
            this.visualizarVentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visualizarProductosToolStripMenuItem
            // 
            this.visualizarProductosToolStripMenuItem.Name = "visualizarProductosToolStripMenuItem";
            this.visualizarProductosToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.visualizarProductosToolStripMenuItem.Text = "Visualizar Productos";
            this.visualizarProductosToolStripMenuItem.Click += new System.EventHandler(this.visualizarProductosToolStripMenuItem_Click);
            // 
            // visualizarCantidadesToolStripMenuItem
            // 
            this.visualizarCantidadesToolStripMenuItem.Name = "visualizarCantidadesToolStripMenuItem";
            this.visualizarCantidadesToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.visualizarCantidadesToolStripMenuItem.Text = "Visualizar Cantidades";
            this.visualizarCantidadesToolStripMenuItem.Click += new System.EventHandler(this.visualizarCantidadesToolStripMenuItem_Click);
            // 
            // visualizarVentasToolStripMenuItem
            // 
            this.visualizarVentasToolStripMenuItem.Name = "visualizarVentasToolStripMenuItem";
            this.visualizarVentasToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.visualizarVentasToolStripMenuItem.Text = "Visualizar Ventas";
            this.visualizarVentasToolStripMenuItem.Click += new System.EventHandler(this.visualizarVentasToolStripMenuItem_Click);
            // 
            // sesion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVisualizarVentas);
            this.Controls.Add(this.btVisualizarCantidades);
            this.Controls.Add(this.btVisualizarProductos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sesion3";
            this.Text = "sesion3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVisualizarProductos;
        private System.Windows.Forms.Button btVisualizarCantidades;
        private System.Windows.Forms.Button btVisualizarVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualizarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarCantidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarVentasToolStripMenuItem;
    }
}