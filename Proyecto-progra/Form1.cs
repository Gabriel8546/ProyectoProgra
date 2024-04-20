namespace Proyecto_progra
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            // se reciben los datos dados por el usuario
            string nomCliente = txtNombreCliente.Text;
            string tipoCliente = cmbTipoCliente.Text;
            string tipoPrestamo = cmbTipoPrestamo.Text;
            int plazoMeses = int.Parse(txtPlazoMeses.Text);
            double MontonSolicitado = double.Parse(txtMontoSolicitado.Text);
            double TotPagar=0;
            double CuotaMensual =0;
            // en varios Objetos se hacen los calculos y aqui se "Reciben"
            TotPagar = CalcularMontoTotalPagar(tipoPrestamo, MontonSolicitado, plazoMeses);
            CuotaMensual = CalcMontoMunsual(TotPagar, plazoMeses);
            //Luego verificamos el tipo de cliente,es decir si se puede hacer el prestamo y si tiene descuento 
            if (tipoCliente == "Tipo C")
            {
                MessageBox.Show("Lo Sentimos, su solicitud de credito a sido denegada", "Denegacion de prestamo");
                LimpiarDatos();
            }
            else if (tipoCliente == "Tipo A1" || tipoCliente == "TipoA2") {
                AplicarDescu(0.2,MontonSolicitado);    
            }
        }
        private void AplicarDescu(double porcetajeDescu, double MontonSolicitado)
        {
            MontonSolicitado = MontonSolicitado - (MontonSolicitado * porcetajeDescu);
      
        }
        private void LimpiarDatos() { 
             
        }
        private double ObtenerInteresPagar(string tipoPrestamo)
        {

            switch (tipoPrestamo)
            {
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


        private double CalcularMontoTotalPagar( string tipoPrestamo, double MontonSolicitado, int plazoMeses) {
            double interesAnual = ObtenerInteresPagar(tipoPrestamo);
            double MontoPagar =( MontonSolicitado * interesAnual) * plazoMeses;
            return MontoPagar;
        }

        private double CalcMontoMunsual(double TotPagar, int plazoMeses) {

            //Calculo el monto mensual 

            double Cuota = TotPagar / plazoMeses;
            return Cuota;
        }
    }
}
