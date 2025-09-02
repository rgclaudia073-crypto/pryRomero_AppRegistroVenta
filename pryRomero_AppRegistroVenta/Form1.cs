namespace pryRomero_AppRegistroVenta
{
    public partial class frmRegistroVenta : Form
    {
        public frmRegistroVenta()
        {
            InitializeComponent();
        }

        public frmRegistroVenta(object numericUpDown2Cantidad)
        {
            this.numericUpDown2Cantidad = numericUpDown2Cantidad;
        }

        //DECLARAR VARIABLE GLOBALES DEL FRM
        DateTime vFecha = DateTime.Now;
        string vProducto = "";
        int vCantidad = 0;
        int vPrecio = 0;
        private object numericUpDown2Cantidad;
        private object mtbPrecio;
        private object lblResultadoRegistro_Click;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistroVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProducto_Click(object sender, EventArgs e)
        {
            vFecha = dtpFecha.Value;
            vProducto = cmbProducto.Text;
            //cboProducto.SelectedItem
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            //vCantidad = int.Parse(numericUpDown2Cantidad
            vPrecio = Convert.ToInt32(mtbPrecioUnitario.Text);


            //mostrar en resultados
            lblResultadoRegistro_Click.=
                vFecha + " " + vProducto
                + " " + vCantidad + " " + vPrecio;
        }

        private void mtbPrecioUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void lblProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Leave(object sender, EventArgs e)
        {

        }

    }
}
