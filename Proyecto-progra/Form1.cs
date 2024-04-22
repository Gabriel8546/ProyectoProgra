using System.Diagnostics.Metrics;

namespace Proyecto_progra
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();

        }

        private bool ValidarLimitesPrestamos(string tipoPrestamo, int MontonSolicitado, int plazoMeses) { 
        
         double montoMaximo = 0;  
         int  plazoMaximo = 0;
            tipoPrestamo = tipoPrestamo.ToLower();
            switch (tipoPrestamo)
            {

                case "persona regular":
                    montoMaximo = 15000000; 
                    plazoMaximo = 60; 
                    break;
                case "personal rapido":
                    montoMaximo = 1000000; 
                    plazoMaximo = 24; 
                    break;
                case "equipo electromedicina":
                    montoMaximo = 15000000; 
                    plazoMaximo = 84; 
                    break;
                case "emprendimiento y estudios de posgrados":
                    montoMaximo = 15000000; 
                    plazoMaximo = 84; 
                    break;
                case "compra vehiculo nuevo":
                    montoMaximo = 15000000; 
                    plazoMaximo = 60; 
                    break;

                default:
                    MessageBox.Show("Tipo de préstamo desconocido");
                    return false;

            }
        

             if (MontonSolicitado > montoMaximo)
                {
                    MessageBox.Show($"El monto solicitado excede el máximo permitido para el tipo de prestamo " +tipoPrestamo);
                    return false;
                }
            if (plazoMeses > plazoMaximo)
            {
                MessageBox.Show($"El plazo solicitado excede el máximo permitido el tipo de prestamo " + tipoPrestamo);
                return false;
            }

            return true;
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            // se reciben los datos dados por el usuario
            string nomCliente = txtNombreCliente.Text;
            string tipoCliente = cmbTipoCliente.Text;
            string tipoPrestamo = cmbTipoPrestamo.Text;
            int plazoMeses = int.Parse(txtPlazoMeses.Text);
            int MontonSolicitado = int.Parse(txtMontoSolicitado.Text);
            double TotPagar;
            double CuotaMensual;
            if (!ValidarLimitesPrestamos(tipoPrestamo, MontonSolicitado, plazoMeses))
             {
                return; //detiene la ejecucion antes de que se termine 
            }
            // en varios Objetos se hacen los calculos y aqui se "Reciben"
            TotPagar = CalcularMontoTotalPagar(tipoPrestamo, MontonSolicitado, plazoMeses);
            CuotaMensual = CalcMontoMunsual(TotPagar, plazoMeses);

            //Luego verificamos el tipo de cliente,es decir si se puede hacer el prestamo y si tiene descuento 
            if (tipoCliente == "Tipo C")
            {
                MessageBox.Show("Lo Sentimos, su solicitud de credito a sido denegada", "Denegacion de prestamo");
                LimpiarDatos();
            }
            else if (tipoCliente == "Tipo A1" || tipoCliente == "TipoA2")
            {
                AplicarDescu(0.02, TotPagar);
            }




            string resu = "Estimado " + nomCliente + ", como cliente  " + tipoCliente + " el monto total a pagar es " + TotPagar + " \n y una cuota  mensual  de " + CuotaMensual;
            labResultado.Text = resu;
            MostrarGatantias(tipoPrestamo);
        }
        private void AplicarDescu(double porcetajeDescu, double TotPagar)
        {
            TotPagar = TotPagar - (TotPagar * porcetajeDescu);

        }
        private void LimpiarDatos()
        {
            cmbTipoCliente.Items.Clear();   
            cmbTipoPrestamo.Items.Clear();
            txtPlazoMeses.Clear();  
            txtMontoSolicitado.Clear();
            LbnTextoFinal.Text = "";
            labResultado.Text = "";
        }

        private void MostrarGatantias(string tipoPrestamo)
        {
            string garantias = "";
            garantias = ObtenerGarantias(tipoPrestamo);
            string imprimir = "Las garantias para este tipo de prestamo son:\n" + garantias;


            LbnTextoFinal.Text = imprimir;

        }
        private string ObtenerGarantias(string tipoPrestamo)
        {
            tipoPrestamo = tipoPrestamo.ToLower();
            
            switch (tipoPrestamo)
            {

                case "persona regular":
                    return "Fiduciarias, Hipotecarias o Prendaria";
                case "personal rapido":
                    return "Constancia Salarial Deducción de Planilla";
                case "equipo electromedicina":
                    return "Fiduciarias";
                case "emprendimiento y estudios de posgrados":
                    return "Fiduciarias o Hipotecarias";
                case "compra vehiculo nuevo":
                    return "Fiduciarias, Hipotecarias o Prendaria";
                default:
                    return "";
            }
        }
        private double ObtenerInteresPagar(string tipoPrestamo)
        {
            tipoPrestamo = tipoPrestamo.ToLower();
            switch (tipoPrestamo)
            {
                case "persona regular":
                    return 0.15;
                case "personal rapido":
                    return 0.18;
                case "equipo electromedicina":
                    return 0.12;
                case "emprendimiento y estudios de posgrados":
                    return 0.12;
                case "compra vehiculo nuevo":
                    return 0.12;

                default:
                    return 0.0;
            }



        }


        private double CalcularMontoTotalPagar(string tipoPrestamo, double MontonSolicitado, int plazoMeses)
        {
            double interesMesual = ObtenerInteresPagar(tipoPrestamo) / 12;
            double InteresAcumulados = (MontonSolicitado * interesMesual) * plazoMeses;
            double MontoPagar = MontonSolicitado + InteresAcumulados;
            return MontoPagar;
        }

        private double CalcMontoMunsual(double TotPagar, int plazoMeses)
        {

            //Calculo el monto mensual 

            double Cuota = TotPagar / (double)plazoMeses;
            return Cuota;
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
