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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 8);
            label1.Name = "label1";
            label1.Size = new Size(389, 41);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de prestamos ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(206, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre del  cliente ";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(12, 110);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(191, 23);
            txtNombreCliente.TabIndex = 2;
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Items.AddRange(new object[] { "Tipo A1", "TipoA2", "Tipo B", "Tipo C" });
            cmbTipoCliente.Location = new Point(12, 217);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(191, 25);
            cmbTipoCliente.TabIndex = 3;
            // 
            // cmbTipoPrestamo
            // 
            cmbTipoPrestamo.FormattingEnabled = true;
            cmbTipoPrestamo.Items.AddRange(new object[] { "Persona regular ", "Personal Rapido ", "Equipo electromedicina", "Emprendimineto y estudios de postgrados ", "Compra Vehiculo Nuevo" });
            cmbTipoPrestamo.Location = new Point(12, 350);
            cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            cmbTipoPrestamo.Size = new Size(191, 25);
            cmbTipoPrestamo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 5;
            label3.Text = "Tipo del cliente";
            // 
            // lab4
            // 
            lab4.AutoSize = true;
            lab4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab4.Location = new Point(16, 308);
            lab4.Name = "lab4";
            lab4.Size = new Size(178, 28);
            lab4.TabIndex = 6;
            lab4.Text = "Tipo de prestamo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(839, 67);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 7;
            label4.Text = "Plazo en meses ";
            // 
            // txtPlazoMeses
            // 
            txtPlazoMeses.Location = new Point(839, 110);
            txtPlazoMeses.Name = "txtPlazoMeses";
            txtPlazoMeses.Size = new Size(191, 23);
            txtPlazoMeses.TabIndex = 8;
            // 
            // txtMontoSolicitado
            // 
            txtMontoSolicitado.Location = new Point(839, 215);
            txtMontoSolicitado.Name = "txtMontoSolicitado";
            txtMontoSolicitado.Size = new Size(191, 23);
            txtMontoSolicitado.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(839, 172);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 9;
            label5.Text = "Solicitado ";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(481, 391);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 29);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1115, 483);
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
            Name = "form1";
            Text = "Form1";
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
    }
}
