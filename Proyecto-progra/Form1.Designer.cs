namespace Proyecto_progra
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            label1 = new Label();
            label2 = new Label();
            txtNombreCliente = new TextBox();
            cmbTipoCliente = new ComboBox();
            cmbTipoPrestamo = new ComboBox();
            label3 = new Label();
            lab4 = new Label();
            label4 = new Label();
            txtPlazoMeses = new TextBox();
            txtMontoSolicitado = new TextBox();
            label5 = new Label();
            btnCalcular = new Button();
            LbnTextoFinal = new Label();
            labResultado = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(389, 41);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de prestamos ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(206, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre del  cliente ";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtNombreCliente.Location = new Point(13, 115);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(191, 23);
            txtNombreCliente.TabIndex = 2;
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Items.AddRange(new object[] { "Tipo A1", "TipoA2", "Tipo B", "Tipo C" });
            cmbTipoCliente.Location = new Point(13, 222);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(191, 25);
            cmbTipoCliente.TabIndex = 3;
            // 
            // cmbTipoPrestamo
            // 
            cmbTipoPrestamo.FormattingEnabled = true;
            cmbTipoPrestamo.Items.AddRange(new object[] { "Persona Regular", "Personal Rapido", "Equipo Electromedicina", "Emprendimiento y estudios de postgrados ", "Compra Vehiculo Nuevo" });
            cmbTipoPrestamo.Location = new Point(13, 355);
            cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            cmbTipoPrestamo.Size = new Size(191, 25);
            cmbTipoPrestamo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 177);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 5;
            label3.Text = "Tipo del cliente";
            // 
            // lab4
            // 
            lab4.AutoSize = true;
            lab4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab4.Location = new Point(17, 313);
            lab4.Name = "lab4";
            lab4.Size = new Size(178, 28);
            lab4.TabIndex = 6;
            lab4.Text = "Tipo de prestamo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(283, 72);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 7;
            label4.Text = "Plazo en meses ";
            // 
            // txtPlazoMeses
            // 
            txtPlazoMeses.Location = new Point(248, 115);
            txtPlazoMeses.Name = "txtPlazoMeses";
            txtPlazoMeses.Size = new Size(191, 23);
            txtPlazoMeses.TabIndex = 8;
            // 
            // txtMontoSolicitado
            // 
            txtMontoSolicitado.Location = new Point(238, 223);
            txtMontoSolicitado.Name = "txtMontoSolicitado";
            txtMontoSolicitado.Size = new Size(191, 23);
            txtMontoSolicitado.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(267, 177);
            label5.Name = "label5";
            label5.Size = new Size(181, 28);
            label5.TabIndex = 9;
            label5.Text = "Monto Solicitado ";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(285, 349);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 29);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // LbnTextoFinal
            // 
            LbnTextoFinal.AutoSize = true;
            LbnTextoFinal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbnTextoFinal.Location = new Point(12, 500);
            LbnTextoFinal.Name = "LbnTextoFinal";
            LbnTextoFinal.Size = new Size(0, 23);
            LbnTextoFinal.TabIndex = 12;
            // 
            // labResultado
            // 
            labResultado.AutoSize = true;
            labResultado.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labResultado.Location = new Point(12, 419);
            labResultado.Name = "labResultado";
            labResultado.Size = new Size(0, 23);
            labResultado.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_financial_calculator_computer_icons_calculation_calculator_electronics_text_rectangle__1_;
            pictureBox1.Location = new Point(456, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(538, 608);
            Controls.Add(pictureBox1);
            Controls.Add(labResultado);
            Controls.Add(LbnTextoFinal);
            Controls.Add(btnCalcular);
            Controls.Add(txtMontoSolicitado);
            Controls.Add(label5);
            Controls.Add(txtPlazoMeses);
            Controls.Add(label4);
            Controls.Add(lab4);
            Controls.Add(label3);
            Controls.Add(cmbTipoPrestamo);
            Controls.Add(cmbTipoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de prestamos ";
            Load += form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreCliente;
        private ComboBox cmbTipoCliente;
        private ComboBox cmbTipoPrestamo;
        private Label label3;
        private Label lab4;
        private Label label4;
        private TextBox txtPlazoMeses;
        private TextBox txtMontoSolicitado;
        private Label label5;
        private Button btnCalcular;
       private Label LbnTextoFinal;
        private Label labResultado;
        private PictureBox pictureBox1;
    }
}
