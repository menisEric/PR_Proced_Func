namespace prGestionAhorros
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnAbrirCuenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstRetiro = new System.Windows.Forms.ListBox();
            this.lstDeposito = new System.Windows.Forms.ListBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.Saldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.btnAbrirCuenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los Datos";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(138, 105);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(196, 26);
            this.txtMonto.TabIndex = 8;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(138, 47);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(196, 26);
            this.txtCliente.TabIndex = 7;
            // 
            // btnAbrirCuenta
            // 
            this.btnAbrirCuenta.Location = new System.Drawing.Point(415, 47);
            this.btnAbrirCuenta.Name = "btnAbrirCuenta";
            this.btnAbrirCuenta.Size = new System.Drawing.Size(109, 37);
            this.btnAbrirCuenta.TabIndex = 4;
            this.btnAbrirCuenta.Text = "Abrir cuenta";
            this.btnAbrirCuenta.UseVisualStyleBackColor = true;
            this.btnAbrirCuenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistro);
            this.groupBox2.Controls.Add(this.btnDeposito);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trasacciones";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(280, 50);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(156, 36);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(82, 50);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(156, 36);
            this.btnDeposito.TabIndex = 7;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstRetiro);
            this.groupBox3.Controls.Add(this.lstDeposito);
            this.groupBox3.Controls.Add(this.txtSaldo);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.Saldo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 255);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historial";
            // 
            // lstRetiro
            // 
            this.lstRetiro.FormattingEnabled = true;
            this.lstRetiro.ItemHeight = 20;
            this.lstRetiro.Location = new System.Drawing.Point(203, 92);
            this.lstRetiro.Name = "lstRetiro";
            this.lstRetiro.Size = new System.Drawing.Size(152, 144);
            this.lstRetiro.TabIndex = 8;
            // 
            // lstDeposito
            // 
            this.lstDeposito.FormattingEnabled = true;
            this.lstDeposito.ItemHeight = 20;
            this.lstDeposito.Location = new System.Drawing.Point(18, 92);
            this.lstDeposito.Name = "lstDeposito";
            this.lstDeposito.Size = new System.Drawing.Size(154, 144);
            this.lstDeposito.TabIndex = 7;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(406, 172);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(118, 26);
            this.txtSaldo.TabIndex = 6;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(406, 213);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(118, 36);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nnuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.Location = new System.Drawing.Point(402, 131);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(54, 20);
            this.Saldo.TabIndex = 1;
            this.Saldo.Text = "Saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Retiros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Depositos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gestion de ahorro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnAbrirCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstRetiro;
        private System.Windows.Forms.ListBox lstDeposito;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label Saldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

