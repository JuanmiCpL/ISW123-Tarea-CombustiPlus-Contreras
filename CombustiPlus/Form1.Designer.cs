namespace CombustiPlus
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnDespachar = new Button();
            btnCotizar = new Button();
            cmbPago = new ComboBox();
            nudGalones = new NumericUpDown();
            cmbCombustible = new ComboBox();
            txtPlaca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lstDetalle = new ListBox();
            groupBox3 = new GroupBox();
            lstDespacho = new ListBox();
            btnPorCombustible = new Button();
            lblResumen = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDespachar);
            groupBox1.Controls.Add(btnCotizar);
            groupBox1.Controls.Add(cmbPago);
            groupBox1.Controls.Add(nudGalones);
            groupBox1.Controls.Add(cmbCombustible);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Despacho";
            // 
            // btnDespachar
            // 
            btnDespachar.Location = new Point(187, 220);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(172, 41);
            btnDespachar.TabIndex = 8;
            btnDespachar.Text = "Despachar";
            btnDespachar.UseVisualStyleBackColor = true;
            btnDespachar.Click += btnDespachar_Click;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(6, 220);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(172, 41);
            btnCotizar.TabIndex = 7;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // cmbPago
            // 
            cmbPago.FormattingEnabled = true;
            cmbPago.Items.AddRange(new object[] { "Efectivo,", "Tarjeta" });
            cmbPago.Location = new Point(143, 174);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(216, 28);
            cmbPago.TabIndex = 6;
            // 
            // nudGalones
            // 
            nudGalones.Location = new Point(143, 129);
            nudGalones.Name = "nudGalones";
            nudGalones.Size = new Size(216, 27);
            nudGalones.TabIndex = 5;
            // 
            // cmbCombustible
            // 
            cmbCombustible.FormattingEnabled = true;
            cmbCombustible.Items.AddRange(new object[] { "Premium,", "Regular,", "Gasoil" });
            cmbCombustible.Location = new Point(143, 82);
            cmbCombustible.Name = "cmbCombustible";
            cmbCombustible.Size = new Size(216, 28);
            cmbCombustible.TabIndex = 1;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(143, 36);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(216, 27);
            txtPlaca.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 174);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 128);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Galones:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 82);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Combustible:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Placa:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstDetalle);
            groupBox2.Location = new Point(12, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 185);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // lstDetalle
            // 
            lstDetalle.FormattingEnabled = true;
            lstDetalle.Location = new Point(6, 26);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(362, 144);
            lstDetalle.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstDespacho);
            groupBox3.Controls.Add(btnPorCombustible);
            groupBox3.Location = new Point(409, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(678, 357);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // lstDespacho
            // 
            lstDespacho.FormattingEnabled = true;
            lstDespacho.Location = new Point(16, 26);
            lstDespacho.Name = "lstDespacho";
            lstDespacho.Size = new Size(643, 264);
            lstDespacho.TabIndex = 4;
            // 
            // btnPorCombustible
            // 
            btnPorCombustible.Location = new Point(16, 305);
            btnPorCombustible.Name = "btnPorCombustible";
            btnPorCombustible.Size = new Size(265, 37);
            btnPorCombustible.TabIndex = 3;
            btnPorCombustible.Text = "Galones por combustible";
            btnPorCombustible.UseVisualStyleBackColor = true;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(409, 381);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(50, 20);
            lblResumen.TabIndex = 3;
            lblResumen.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 561);
            Controls.Add(lblResumen);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDespachar;
        private Button btnCotizar;
        private ComboBox cmbPago;
        private NumericUpDown nudGalones;
        private ComboBox cmbCombustible;
        private TextBox txtPlaca;
        private GroupBox groupBox2;
        private ListBox lstDetalle;
        private GroupBox groupBox3;
        private ListBox lstDespacho;
        private Button btnPorCombustible;
        private Label lblResumen;
    }
}
