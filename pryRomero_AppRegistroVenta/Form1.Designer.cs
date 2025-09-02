namespace pryRomero_AppRegistroVenta
{
    partial class frmRegistroVenta
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
            Label lblResultadoRegistrar;
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            nudCantidad = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            btnRegistrar = new Button();
            cmbProducto = new ComboBox();
            btnCancelar = new Button();
            mtbPrecioUnitario = new MaskedTextBox();
            lblResultadoRegistrar = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblResultadoRegistrar
            // 
            lblResultadoRegistrar.AutoSize = true;
            lblResultadoRegistrar.Enabled = false;
            lblResultadoRegistrar.Location = new Point(120, 378);
            lblResultadoRegistrar.Name = "lblResultadoRegistrar";
            lblResultadoRegistrar.Size = new Size(32, 15);
            lblResultadoRegistrar.TabIndex = 13;
            lblResultadoRegistrar.Text = "_____";
            lblResultadoRegistrar.Visible = false;
            lblResultadoRegistrar.Click += lblResultado_Click;
            lblResultadoRegistrar.Leave += lblResultado_Leave;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblFecha.Location = new Point(12, 25);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(95, 40);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblProducto.Location = new Point(12, 82);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(144, 40);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            lblProducto.TextChanged += lblProducto_TextChanged;
            lblProducto.Click += dtpFecha_ValueChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblCantidad.Location = new Point(12, 147);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(140, 40);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            lblCantidad.Click += label1_Click;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblPrecioUnitario.Location = new Point(16, 205);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(220, 40);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio unitario";
            lblPrecioUnitario.Click += label2_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(296, 147);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(200, 33);
            nudCantidad.TabIndex = 4;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(296, 39);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 8;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(356, 286);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(124, 32);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // cmbProducto
            // 
            cmbProducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(296, 89);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(200, 33);
            cmbProducto.TabIndex = 10;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            cmbProducto.Click += cmbProducto_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(486, 286);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 32);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Location = new Point(296, 205);
            mtbPrecioUnitario.Mask = "0000000";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(100, 23);
            mtbPrecioUnitario.TabIndex = 12;
            mtbPrecioUnitario.TextChanged += mtbPrecioUnitario_TextChanged;
            // 
            // frmRegistroVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 485);
            Controls.Add(lblResultadoRegistrar);
            Controls.Add(mtbPrecioUnitario);
            Controls.Add(btnCancelar);
            Controls.Add(cmbProducto);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpFecha);
            Controls.Add(nudCantidad);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "frmRegistroVenta";
            Text = "Registro de Venta";
            Load += frmRegistroVenta_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private NumericUpDown nudCantidad;
        private TextBox textBox1;
        private DateTimePicker dtpFecha;
        private Button btnRegistrar;
        private ComboBox cmbProducto;
        private Button btnCancelar;
        private MaskedTextBox mtbPrecioUnitario;
        private Label lblResultadoRegistrar;
    }
}
