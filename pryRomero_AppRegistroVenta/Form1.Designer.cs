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
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            cmbCantidad = new NumericUpDown();
            cmbFecha = new DateTimePicker();
            lblRegistrar = new Button();
            cmbProducto = new ComboBox();
            lblCancelar = new Button();
            cmbPrecioUsuario = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)cmbCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblFecha.Location = new Point(34, 42);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(95, 40);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            lblFecha.Click += lblFecha_TextChanged;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblProducto.Location = new Point(30, 104);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(144, 40);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            lblProducto.Click += label2_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblCantidad.Location = new Point(34, 179);
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
            lblPrecioUnitario.Location = new Point(30, 260);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(220, 40);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio unitario";
            lblPrecioUnitario.Click += label2_Click;
            // 
            // cmbCantidad
            // 
            cmbCantidad.Enabled = false;
            cmbCantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCantidad.Location = new Point(338, 186);
            cmbCantidad.Name = "cmbCantidad";
            cmbCantidad.Size = new Size(200, 33);
            cmbCantidad.TabIndex = 4;
            // 
            // cmbFecha
            // 
            cmbFecha.Location = new Point(338, 42);
            cmbFecha.Name = "cmbFecha";
            cmbFecha.Size = new Size(200, 23);
            cmbFecha.TabIndex = 8;
            // 
            // lblRegistrar
            // 
            lblRegistrar.Enabled = false;
            lblRegistrar.Location = new Point(367, 350);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(149, 46);
            lblRegistrar.TabIndex = 9;
            lblRegistrar.Text = "Registrar";
            lblRegistrar.UseVisualStyleBackColor = true;
            lblRegistrar.Click += lblRegistrar_Click;
            // 
            // cmbProducto
            // 
            cmbProducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(338, 111);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(200, 33);
            cmbProducto.TabIndex = 10;
            cmbProducto.TextChanged += cmbProducto_TextChanged;
            // 
            // lblCancelar
            // 
            lblCancelar.Location = new Point(617, 350);
            lblCancelar.Name = "lblCancelar";
            lblCancelar.Size = new Size(149, 46);
            lblCancelar.TabIndex = 11;
            lblCancelar.Text = "Cancelar";
            lblCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbPrecioUsuario
            // 
            cmbPrecioUsuario.Enabled = false;
            cmbPrecioUsuario.Location = new Point(338, 277);
            cmbPrecioUsuario.Mask = "00000";
            cmbPrecioUsuario.Name = "cmbPrecioUsuario";
            cmbPrecioUsuario.Size = new Size(200, 23);
            cmbPrecioUsuario.TabIndex = 12;
            // 
            // frmRegistroVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbPrecioUsuario);
            Controls.Add(lblCancelar);
            Controls.Add(cmbProducto);
            Controls.Add(lblRegistrar);
            Controls.Add(cmbFecha);
            Controls.Add(cmbCantidad);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "frmRegistroVenta";
            Text = "Registro de Venta";
            Load += frmRegistroVenta_Load;
            ((System.ComponentModel.ISupportInitialize)cmbCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private NumericUpDown cmbCantidad;
        private TextBox textBox1;
        private DateTimePicker cmbFecha;
        private Button lblRegistrar;
        private ComboBox cmbProducto;
        private Button lblCancelar;
        private MaskedTextBox cmbPrecioUsuario;
    }
}
