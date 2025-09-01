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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            lblRegistrar = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            lblFecha.Click += label1_Click;
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
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(338, 186);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 33);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown2.Location = new Point(338, 260);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(200, 33);
            numericUpDown2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(338, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // lblRegistrar
            // 
            lblRegistrar.Location = new Point(613, 367);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(149, 46);
            lblRegistrar.TabIndex = 9;
            lblRegistrar.Text = "Registrar";
            lblRegistrar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(338, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 33);
            comboBox1.TabIndex = 10;
            // 
            // frmRegistroVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(lblRegistrar);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "frmRegistroVenta";
            Text = "Registro de Venta";
            Load += frmRegistroVenta_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button lblRegistrar;
        private ComboBox comboBox1;
    }
}
