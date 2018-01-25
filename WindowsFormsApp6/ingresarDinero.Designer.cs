namespace WindowsFormsApp6
{
    partial class ingresarDinero
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
            this.txtIdCuenta = new System.Windows.Forms.TextBox();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.lblDinero = new System.Windows.Forms.Label();
            this.lblidCuenta = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdCuenta
            // 
            this.txtIdCuenta.Location = new System.Drawing.Point(154, 396);
            this.txtIdCuenta.Name = "txtIdCuenta";
            this.txtIdCuenta.Size = new System.Drawing.Size(100, 22);
            this.txtIdCuenta.TabIndex = 2;
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(478, 396);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(100, 22);
            this.txtDinero.TabIndex = 4;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(478, 349);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(50, 17);
            this.lblDinero.TabIndex = 5;
            this.lblDinero.Text = "Dinero";
            // 
            // lblidCuenta
            // 
            this.lblidCuenta.AutoSize = true;
            this.lblidCuenta.Location = new System.Drawing.Point(154, 348);
            this.lblidCuenta.Name = "lblidCuenta";
            this.lblidCuenta.Size = new System.Drawing.Size(64, 17);
            this.lblidCuenta.TabIndex = 6;
            this.lblidCuenta.Text = "IdCuenta";
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(184, 467);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 7;
            this.btVolver.Text = "volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // ingresarDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 631);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.lblidCuenta);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.txtIdCuenta);
            this.Controls.Add(this.button1);
            this.Name = "ingresarDinero";
            this.Text = "ingresarDinero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdCuenta;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Label lblidCuenta;
        private System.Windows.Forms.Button btVolver;
    }
}