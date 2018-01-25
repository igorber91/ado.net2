namespace WindowsFormsApp6
{
    partial class ventas2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.btProductosVendidos = new System.Windows.Forms.Button();
            this.btPrecioProductos = new System.Windows.Forms.Button();
            this.btPrecioTotal = new System.Windows.Forms.Button();
            this.btVentas = new System.Windows.Forms.Button();
            this.btVentas2 = new System.Windows.Forms.Button();
            this.btVerProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(400, 347);
            this.txtIdVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(132, 22);
            this.txtIdVenta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 415);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ver productos Vendidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 316);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "NºVenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ver precio de los productos vendidos";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(253, 497);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(511, 215);
            this.dataGridView2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 738);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ver  todos los productos y precios";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(1015, 118);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(94, 17);
            this.lblPrecioTotal.TabIndex = 18;
            this.lblPrecioTotal.Text = "lblPrecioTotal";
            // 
            // btProductosVendidos
            // 
            this.btProductosVendidos.Location = new System.Drawing.Point(145, 434);
            this.btProductosVendidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btProductosVendidos.Name = "btProductosVendidos";
            this.btProductosVendidos.Size = new System.Drawing.Size(201, 30);
            this.btProductosVendidos.TabIndex = 20;
            this.btProductosVendidos.Text = "Ver productos vendidos";
            this.btProductosVendidos.UseVisualStyleBackColor = true;
            this.btProductosVendidos.Click += new System.EventHandler(this.btProductosVendidos_Click);
            // 
            // btPrecioProductos
            // 
            this.btPrecioProductos.Location = new System.Drawing.Point(599, 433);
            this.btPrecioProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPrecioProductos.Name = "btPrecioProductos";
            this.btPrecioProductos.Size = new System.Drawing.Size(329, 31);
            this.btPrecioProductos.TabIndex = 21;
            this.btPrecioProductos.Text = "Ver precio de productos vendidos";
            this.btPrecioProductos.UseVisualStyleBackColor = true;
            this.btPrecioProductos.Click += new System.EventHandler(this.btPrecioProductos_Click);
            // 
            // btPrecioTotal
            // 
            this.btPrecioTotal.Location = new System.Drawing.Point(1009, 65);
            this.btPrecioTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPrecioTotal.Name = "btPrecioTotal";
            this.btPrecioTotal.Size = new System.Drawing.Size(100, 28);
            this.btPrecioTotal.TabIndex = 22;
            this.btPrecioTotal.Text = "PrecioTotal";
            this.btPrecioTotal.UseVisualStyleBackColor = true;
            this.btPrecioTotal.Click += new System.EventHandler(this.btPrecioTotal_Click);
            // 
            // btVentas
            // 
            this.btVentas.Location = new System.Drawing.Point(1119, 284);
            this.btVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVentas.Name = "btVentas";
            this.btVentas.Size = new System.Drawing.Size(100, 28);
            this.btVentas.TabIndex = 24;
            this.btVentas.Text = "Ventas";
            this.btVentas.UseVisualStyleBackColor = true;
            this.btVentas.Click += new System.EventHandler(this.btVentas_Click);
            // 
            // btVentas2
            // 
            this.btVentas2.Location = new System.Drawing.Point(1119, 347);
            this.btVentas2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVentas2.Name = "btVentas2";
            this.btVentas2.Size = new System.Drawing.Size(100, 28);
            this.btVentas2.TabIndex = 25;
            this.btVentas2.Text = "Ventas2";
            this.btVentas2.UseVisualStyleBackColor = true;
            this.btVentas2.Click += new System.EventHandler(this.btVentas2_Click);
            // 
            // btVerProductos
            // 
            this.btVerProductos.Location = new System.Drawing.Point(441, 769);
            this.btVerProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVerProductos.Name = "btVerProductos";
            this.btVerProductos.Size = new System.Drawing.Size(143, 28);
            this.btVerProductos.TabIndex = 26;
            this.btVerProductos.Text = "VerProductos";
            this.btVerProductos.UseVisualStyleBackColor = true;
            this.btVerProductos.Click += new System.EventHandler(this.btVerProductos_Click);
            // 
            // ventas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 826);
            this.Controls.Add(this.btVerProductos);
            this.Controls.Add(this.btVentas2);
            this.Controls.Add(this.btVentas);
            this.Controls.Add(this.btPrecioTotal);
            this.Controls.Add(this.btPrecioProductos);
            this.Controls.Add(this.btProductosVendidos);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ventas2";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Button btProductosVendidos;
        private System.Windows.Forms.Button btPrecioProductos;
        private System.Windows.Forms.Button btPrecioTotal;
        private System.Windows.Forms.Button btVentas;
        private System.Windows.Forms.Button btVentas2;
        private System.Windows.Forms.Button btVerProductos;
    }
}