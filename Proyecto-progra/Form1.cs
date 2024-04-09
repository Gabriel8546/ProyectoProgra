namespace Proyecto_progra
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nomCliente = txtNombreCliente.Text;
            string tipoCliente = cmbTipoCliente.Text;
            string tipoPrestamo = cmbTipoPrestamo.Text;
            int plazoMeses = int.Parse(txtPlazoMeses.Text);
            double MontonSolicitado = double.Parse(txtMontoSolicitado.Text);

            double InteresAnual = ObtenerMontoPagar(tipoPrestamo);
            
        }
        private double ObtenerMontoPagar(string tipoPrestamo) {

            switch (tipoPrestamo) {
                case "Persona regular":
                    return 0.15;
                case "Personal Rapido ":
                    return 0.18;
                case "Equipo electromedicina ":
                    return 0.12;
                case "Emprendimineto y estudios de postgrados":
                    return 0.12;
                case "Compra Vehiculo Nuevo":
                    return 0.12;
            
                default:
                    return 0.0;
            }
          
            
        
        }
        
    }
}
