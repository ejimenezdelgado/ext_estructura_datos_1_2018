namespace Ejercicio1
{
    partial class FrmPrincipal
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grbNumero = new System.Windows.Forms.GroupBox();
            this.txtImpresionNumero = new System.Windows.Forms.ListBox();
            this.grbCalculo = new System.Windows.Forms.GroupBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtIniciador = new System.Windows.Forms.NumericUpDown();
            this.txtNumero = new System.Windows.Forms.NumericUpDown();
            this.grbNumero.SuspendLayout();
            this.grbCalculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIniciador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(84, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 17);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(278, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grbNumero
            // 
            this.grbNumero.Controls.Add(this.txtNumero);
            this.grbNumero.Controls.Add(this.txtIniciador);
            this.grbNumero.Controls.Add(this.lblNumero);
            this.grbNumero.Controls.Add(this.btnAgregar);
            this.grbNumero.Controls.Add(this.btnIniciar);
            this.grbNumero.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbNumero.Location = new System.Drawing.Point(0, 0);
            this.grbNumero.Name = "grbNumero";
            this.grbNumero.Size = new System.Drawing.Size(648, 72);
            this.grbNumero.TabIndex = 3;
            this.grbNumero.TabStop = false;
            this.grbNumero.Text = "Ingresar Numero";
            // 
            // txtImpresionNumero
            // 
            this.txtImpresionNumero.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtImpresionNumero.FormattingEnabled = true;
            this.txtImpresionNumero.ItemHeight = 16;
            this.txtImpresionNumero.Location = new System.Drawing.Point(0, 72);
            this.txtImpresionNumero.Name = "txtImpresionNumero";
            this.txtImpresionNumero.Size = new System.Drawing.Size(268, 259);
            this.txtImpresionNumero.TabIndex = 4;
            // 
            // grbCalculo
            // 
            this.grbCalculo.Controls.Add(this.txtMinimo);
            this.grbCalculo.Controls.Add(this.txtMaximo);
            this.grbCalculo.Controls.Add(this.txtPromedio);
            this.grbCalculo.Controls.Add(this.txtSuma);
            this.grbCalculo.Controls.Add(this.lblMinimo);
            this.grbCalculo.Controls.Add(this.lblMaximo);
            this.grbCalculo.Controls.Add(this.lblPromedio);
            this.grbCalculo.Controls.Add(this.lblSuma);
            this.grbCalculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCalculo.Location = new System.Drawing.Point(268, 72);
            this.grbCalculo.Name = "grbCalculo";
            this.grbCalculo.Size = new System.Drawing.Size(380, 259);
            this.grbCalculo.TabIndex = 5;
            this.grbCalculo.TabStop = false;
            this.grbCalculo.Text = "Cálculos";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(15, 42);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(48, 17);
            this.lblSuma.TabIndex = 0;
            this.lblSuma.Text = "Suma:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(15, 71);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(72, 17);
            this.lblPromedio.TabIndex = 1;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(15, 99);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(59, 17);
            this.lblMaximo.TabIndex = 2;
            this.lblMaximo.Text = "Máximo:";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(15, 127);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(56, 17);
            this.lblMinimo.TabIndex = 3;
            this.lblMinimo.Text = "Mínimo:";
            // 
            // txtSuma
            // 
            this.txtSuma.Enabled = false;
            this.txtSuma.Location = new System.Drawing.Point(93, 38);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 22);
            this.txtSuma.TabIndex = 4;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(93, 66);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 22);
            this.txtPromedio.TabIndex = 5;
            // 
            // txtMaximo
            // 
            this.txtMaximo.Enabled = false;
            this.txtMaximo.Location = new System.Drawing.Point(93, 94);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 22);
            this.txtMaximo.TabIndex = 6;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Enabled = false;
            this.txtMinimo.Location = new System.Drawing.Point(93, 122);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(100, 22);
            this.txtMinimo.TabIndex = 7;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(424, 17);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 34);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtIniciador
            // 
            this.txtIniciador.Location = new System.Drawing.Point(505, 29);
            this.txtIniciador.Name = "txtIniciador";
            this.txtIniciador.Size = new System.Drawing.Size(120, 22);
            this.txtIniciador.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(152, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(120, 22);
            this.txtNumero.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 331);
            this.Controls.Add(this.grbCalculo);
            this.Controls.Add(this.txtImpresionNumero);
            this.Controls.Add(this.grbNumero);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.grbNumero.ResumeLayout(false);
            this.grbNumero.PerformLayout();
            this.grbCalculo.ResumeLayout(false);
            this.grbCalculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIniciador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grbNumero;
        private System.Windows.Forms.NumericUpDown txtNumero;
        private System.Windows.Forms.NumericUpDown txtIniciador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ListBox txtImpresionNumero;
        private System.Windows.Forms.GroupBox grbCalculo;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblSuma;
    }
}

