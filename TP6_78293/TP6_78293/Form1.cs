using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace TP7_78293
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string mensajeError = "";
        List<TablaEuler> tablaEuler = new List<TablaEuler>();
        List<TablaRK> tablaRK = new List<TablaRK>();
        enum TipoEvento { Inicio = 1, LlegadaCliente = 2, FinAtSE1 = 3, FinAtSE2 = 4, FinHorno = 5, Fin = 6 }
        enum EstadoServidor { Libre = 1, Ocupado = 2 }
        Generador objGen = new Generador();
        Random objRandom = new Random();
        double minimo = 0;
        int numCliente = 0;
        List<VectorEstadoMostrar> listaMostrar = new List<VectorEstadoMostrar>();
        VectorEstado filaAnterior = new VectorEstado();
        int cantidad;
        int stock = 0;
        double media, a, b, se_enciende_cada, temp_inicial,h;
        int fin_coccion;
        bool FlagPrimerTiempo = false;
        private bool EncenderHorno = false;
        private double x = 0;
        List<string> lstOrdenSE1 = new List<string>();
        List<string> lstOrdenSE2 = new List<string>();
        int cantClientesQueSeFueron = 0;
        
        List<double> lstHoraEntradaCola = new List<double>();
      
        
        private void btnSimular_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos(ref mensajeError))
            {
                cantidad = Convert.ToInt32(txtCantidad.Text);
                stock = Convert.ToInt32(txtStock.Text);
                media = Convert.ToDouble(txt_Media.Text);
                a = Convert.ToDouble(txt_a.Text);
                b = Convert.ToDouble(txt_b.Text);
                h = Convert.ToDouble(_h.Text);
                se_enciende_cada = Convert.ToDouble(txt_EncenderCada.Text);
                fin_coccion = Convert.ToInt32(txt_FinDespuesDe.Text);
                x = se_enciende_cada;
                temp_inicial = Convert.ToDouble(txt_tempInicial.Text);

                for (int i = 0; i < cantidad; i++)
                {
                    VectorEstado filaActual = new VectorEstado();

                    filaActual.LlegadaCliente = new Cliente();
                    filaActual.SEmpleado1 = new Servidor();
                    filaActual.SEmpleado2 = new Servidor();
                    filaActual.SHorno = new Servidor();



                    filaActual.numEvento = i;
                    if (i == 0)
                    {
                        EventoInicio(filaActual);
                    }
                    else
                    {
                        seteo(filaActual, filaAnterior);
                        filaActual.TipoEvento = GenerarProximoEvento(filaAnterior).ToString();
                        filaActual.Reloj = (double)minimo;
                        filaActual.NumCliente = filaActual.TipoEvento.ToString() == TipoEvento.LlegadaCliente.ToString() ? filaAnterior.NumCliente + 1 : filaAnterior.NumCliente;


                        if (filaActual.TipoEvento.ToString() == TipoEvento.LlegadaCliente.ToString())
                        {
                            EventoLlegadaCliente(filaActual, filaAnterior);

                        }
                        if (filaActual.TipoEvento.ToString() == TipoEvento.FinAtSE1.ToString())
                            EventoFinAt1(filaActual, filaAnterior);
                        if (filaActual.TipoEvento.ToString() == TipoEvento.FinAtSE2.ToString())
                            EventoFinAt2(filaActual, filaAnterior);


                        if (filaActual.TipoEvento.ToString() == TipoEvento.FinHorno.ToString())
                        {
                            EventoFinCoccion(filaActual, filaAnterior);
                            FlagPrimerTiempo = true;
                            if (FlagPrimerTiempo)
                                cargarTablaEulerRK();

                        }

                                        


                    }
                    if (txtDesde.Text == "" && txtHasta.Text == "" && i < 500)
                        cargarFila(filaActual);
                    else if (txtDesde.Text != "" && txtDesde.Text != "" && i >= Convert.ToInt32(txtDesde.Text) && i <= Convert.ToInt32(txtHasta.Text))
                        cargarFila(filaActual);

                    filaAnterior = filaActual;

                }
                cargarGrilla();
                btnLimpiar.Enabled = true;

            }

            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK);
            }
        }

        private void cargarTablaEulerRK()
        {
            if (tablaEuler.Count != 0)
                dgvEuler.DataSource = tablaEuler;
            else if (tablaRK.Count != 0)
                dgvRK.DataSource = tablaRK;
        }

        private void cargarGrilla()
        {
            dgvResultados.DataSource = listaMostrar;
            dgvResultados.Refresh();
        }

    
        private void pasaronCincoMin(VectorEstado filaActual)
        {
            int n= lstHoraEntradaCola.Count();
            int cantEliminada = 0;
            for (int i = 0; i < n; i++)
            {
                if(filaActual.Reloj- lstHoraEntradaCola[i]  >= 5)
                {
                    filaActual.ColaClientes= filaActual.ColaClientes -1;
                    cantClientesQueSeFueron += 1;
                    cantEliminada += 1;
                    
                }
            }

            lstHoraEntradaCola.RemoveRange(0, cantEliminada);
            

        }



        private void cargarFila(VectorEstado filaActual)
        {
            VectorEstadoMostrar filaMostrar = new VectorEstadoMostrar();
            filaMostrar.numEvento = filaActual.numEvento;
            filaMostrar.TipoEvento = filaActual.TipoEvento;
            filaMostrar.Reloj = Math.Round(filaActual.Reloj, 5).ToString();
            filaMostrar.NumCliente = filaActual.NumCliente;
            filaMostrar.RndDemandaCliente = Math.Round(filaActual.RndDemandaCliente,5);
            filaMostrar.DemandaCliente = filaActual.DemandaCliente;
            filaMostrar.Venta = filaActual.Venta;
            filaMostrar.Stock = filaActual.Stock;
            filaMostrar.Reap = filaActual.Reap == true ? "Si" : "No";
            filaMostrar.CantReap = filaActual.CantReap;
            filaMostrar.CantPromClienteSeRetira = numCliente > 0 ? ((cantClientesQueSeFueron * 100) / numCliente).ToString("n2") + "%" : 0.ToString("n2") + "%";


            filaMostrar.RndCliente = Math.Round(filaActual.LlegadaCliente.Rnd, 2);
            filaMostrar.TiempoEntreLlegadasCliente = Math.Round(filaActual.LlegadaCliente.Tiempo_Entre_Llegadas, 5);
            filaMostrar.ProximaLlegadaCliente = Math.Round(filaActual.LlegadaCliente.Proxima_Llegada, 5);
            filaMostrar.ColaClientes = filaActual.ColaClientes;

            filaMostrar.EstadoSE1 = filaActual.SEmpleado1.Estado;
            filaMostrar.Cliente_Num_SE1 = filaActual.SEmpleado1.Cliente_Num.ToString();
            filaMostrar.RndSE1 = Math.Round(filaActual.SEmpleado1.Rnd, 2);
            filaMostrar.TiempoDeAtencionSE1 = Math.Round(filaActual.SEmpleado1.TiempoAtencion, 5);
            filaMostrar.ProximoFinAtencionSE1 = Math.Round(filaActual.SEmpleado1.ProximoFinAtencion, 5);
            filaMostrar.OrdenSE1 = lstOrdenSE1.Aggregate((x, y) => x + " , " + y);

            filaMostrar.EstadoSE2 = filaActual.SEmpleado2.Estado;
            filaMostrar.Cliente_Num_SE2 = filaActual.SEmpleado2.Cliente_Num.ToString();
            filaMostrar.RndSE2 = Math.Round(filaActual.SEmpleado2.Rnd, 2);
            filaMostrar.TiempoDeAtencionSE2 = Math.Round(filaActual.SEmpleado2.TiempoAtencion, 5);
            filaMostrar.ProximoFinAtencionSE2 = Math.Round(filaActual.SEmpleado2.ProximoFinAtencion, 5);
            filaMostrar.OrdenSE2 = lstOrdenSE2.Aggregate((x, y) => x + " , " + y);

            filaMostrar.EstadoSHorno = filaActual.SHorno.Estado;
            filaMostrar.TiempoDeAtencionSHorno = Math.Round(filaActual.SHorno.TiempoAtencion, 10);
            filaMostrar.ProximoFinAtencionSHorno = Math.Round(filaActual.SHorno.ProximoFinAtencion, 5);

          

            listaMostrar.Add(filaMostrar);
        }

        private void EventoFinCoccion(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            filaActual.Stock = filaAnterior.Stock + filaAnterior.CantReap;
            filaActual.SHorno.Estado= EstadoServidor.Libre.ToString();
            filaActual.SHorno.ProximoFinAtencion = 0;
            filaActual.CantReap = 0;
        }

        private void EventoFinAt2(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            if (filaAnterior.ColaClientes > 0)
            {
                if (hayStock(filaAnterior))
                {
                    filaActual.SEmpleado2.Estado = EstadoServidor.Ocupado.ToString();
                    filaActual.ColaClientes = filaAnterior.ColaClientes - 1;
                    if(lstHoraEntradaCola.Count()>0)
                        lstHoraEntradaCola.RemoveRange(0, 1);
                    GenerarProximoFinDeAtencionServidorEmpleado(filaActual, 2);
                    filaActual.NumCliente = filaAnterior.SEmpleado2.Cliente_Num;
                    if (filaAnterior.SEmpleado2.Cliente_Num > filaAnterior.SEmpleado1.Cliente_Num)
                        filaActual.SEmpleado2.Cliente_Num += 1;
                    else
                        filaActual.SEmpleado2.Cliente_Num = filaAnterior.SEmpleado1.Cliente_Num + 1;
                    lstOrdenSE2.Add(filaActual.SEmpleado2.Cliente_Num.ToString());


                    montecarlo(filaActual, filaAnterior);
                       
                }
                else
                {
                    filaActual.ColaClientes = 0;
                    cantClientesQueSeFueron += filaActual.ColaClientes;
                }          

            }
            else
            {
                filaActual.SEmpleado2.Estado = EstadoServidor.Libre.ToString();
                filaActual.SEmpleado2.ProximoFinAtencion = 0;
                filaActual.SEmpleado2.Cliente_Num = filaAnterior.SEmpleado2.Cliente_Num;

            }
        }

        private void EventoFinAt1(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            if (filaAnterior.ColaClientes > 0)
            {
                if (hayStock(filaAnterior))
                {
                    filaActual.SEmpleado1.Estado = EstadoServidor.Ocupado.ToString();
                    filaActual.ColaClientes = filaAnterior.ColaClientes - 1;
                    if (lstHoraEntradaCola.Count() > 0)
                        lstHoraEntradaCola.RemoveRange(0, 1);
                    GenerarProximoFinDeAtencionServidorEmpleado(filaActual, 1);

                    filaActual.NumCliente = filaAnterior.SEmpleado1.Cliente_Num;
                    if (filaAnterior.SEmpleado1.Cliente_Num > filaAnterior.SEmpleado2.Cliente_Num)
                        filaActual.SEmpleado1.Cliente_Num += 1;
                    else
                        filaActual.SEmpleado1.Cliente_Num = filaAnterior.SEmpleado2.Cliente_Num + 1;
                    lstOrdenSE1.Add(filaActual.SEmpleado1.Cliente_Num.ToString());
                    montecarlo(filaActual, filaAnterior);
                    

                }
                else
                {
                    filaActual.ColaClientes = 0;
                    cantClientesQueSeFueron += filaActual.ColaClientes;
                }

            }
            else
            {
                
                filaActual.SEmpleado1.Estado = EstadoServidor.Libre.ToString();
                filaActual.SEmpleado1.ProximoFinAtencion = 0;
                filaActual.SEmpleado1.Cliente_Num = filaAnterior.SEmpleado1.Cliente_Num;

            }
        }

        private bool ValidarDatos(ref string mensajeError)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                mensajeError = "Debe ingresar una cantidad de simulaciones a generar";
                txtCantidad.Focus();
                return false;
            }
            if (txtDesde.Text != "" && txtHasta.Text != "")
            {
                if (Convert.ToInt32(txtDesde.Text) > Convert.ToInt32(txtHasta.Text))
                {
                    mensajeError = "La cantidad desde debe ser < a hasta";
                    txtDesde.Focus();
                    return false;
                }
            }
            
            return true;
        }

        private void EventoInicio(VectorEstado filaActual)
        {
            filaActual.TipoEvento = TipoEvento.Inicio.ToString();
            filaActual.Reloj = (double)0;
            filaActual.NumCliente = 0;
            filaActual.ColaClientes = 0;
            filaActual.Stock = stock;

            filaActual.SEmpleado1.Estado = EstadoServidor.Libre.ToString();
            filaActual.SEmpleado1.ProximoFinAtencion = 0;
            lstOrdenSE1.Add("-");
           
            filaActual.SEmpleado2.Estado = EstadoServidor.Libre.ToString();
            filaActual.SEmpleado2.ProximoFinAtencion = 0;
            lstOrdenSE2.Add("-");

            filaActual.SHorno.Estado = EstadoServidor.Libre.ToString();
            filaActual.SHorno.ProximoFinAtencion = 0;
        
            GenerarProximoCliente(filaActual);
        }

        private void GenerarProximoCliente(VectorEstado fila)
        {
            fila.LlegadaCliente.Rnd = objRandom.NextDouble();          
            fila.LlegadaCliente.Tiempo_Entre_Llegadas = objGen.generarExponencial(media, (double)fila.LlegadaCliente.Rnd);
            fila.LlegadaCliente.Proxima_Llegada = (double)(fila.Reloj + (double)fila.LlegadaCliente.Tiempo_Entre_Llegadas);
        }

        private void seteo(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            filaActual.LlegadaCliente.Proxima_Llegada = filaAnterior.LlegadaCliente.Proxima_Llegada;
            filaActual.SEmpleado1.Estado = filaAnterior.SEmpleado1.Estado;
            filaActual.SEmpleado1.ProximoFinAtencion = filaAnterior.SEmpleado1.ProximoFinAtencion;
            filaActual.SEmpleado1.Cliente_Num = filaAnterior.SEmpleado1.Cliente_Num;
            filaActual.ColaClientes = filaAnterior.ColaClientes;
            filaActual.SEmpleado2.ProximoFinAtencion = filaAnterior.SEmpleado2.ProximoFinAtencion;
            filaActual.SEmpleado2.Estado = filaAnterior.SEmpleado2.Estado;
            filaActual.SEmpleado2.Cliente_Num = filaAnterior.SEmpleado2.Cliente_Num;
            filaActual.SHorno.ProximoFinAtencion = filaAnterior.SHorno.ProximoFinAtencion;
            filaActual.SHorno.Estado = filaAnterior.SHorno.Estado;
            filaActual.Stock = filaAnterior.Stock;
            filaActual.CantReap = filaAnterior.CantReap;
            
           
        }

        private TipoEvento GenerarProximoEvento(VectorEstado fila)
        {
            List<double> lst = new List<double>();

            if (fila.Reloj >= x)
            {
                x += se_enciende_cada;
                EncenderHorno = true;
                
            }

            if (fila.LlegadaCliente.Proxima_Llegada != 0)
                lst.Add(fila.LlegadaCliente.Proxima_Llegada);

            if (fila.SEmpleado1.ProximoFinAtencion != 0)
                lst.Add(fila.SEmpleado1.ProximoFinAtencion);

            if (fila.SEmpleado2.ProximoFinAtencion != 0)
                lst.Add(fila.SEmpleado2.ProximoFinAtencion);

            if (fila.SHorno.ProximoFinAtencion != 0)
                lst.Add(fila.SHorno.ProximoFinAtencion);           

            minimo = lst.Min();
            if (minimo == fila.LlegadaCliente.Proxima_Llegada)
                return TipoEvento.LlegadaCliente;
            else if (minimo == fila.SEmpleado1.ProximoFinAtencion)
                return TipoEvento.FinAtSE1;
            else if (minimo == fila.SEmpleado2.ProximoFinAtencion)
                return TipoEvento.FinAtSE2;
            else 
                return TipoEvento.FinHorno;

        }


        private void EventoLlegadaCliente(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            GenerarProximoCliente(filaActual);
            numCliente += 1;
            filaActual.NumCliente = numCliente;

            if (hayStock(filaAnterior) && filaAnterior.SEmpleado1.Estado == EstadoServidor.Libre.ToString())
            {
                filaActual.SEmpleado1.Estado = EstadoServidor.Ocupado.ToString();
                filaActual.SEmpleado2.Estado = filaAnterior.SEmpleado2.Estado;
                filaActual.SEmpleado1.Cliente_Num = filaActual.NumCliente;
                lstOrdenSE1.Add(filaActual.SEmpleado1.Cliente_Num.ToString());
                GenerarProximoFinDeAtencionServidorEmpleado(filaActual,1);
                montecarlo(filaActual, filaAnterior);
                
            }
            else if(hayStock(filaAnterior) && filaAnterior.SEmpleado2.Estado == EstadoServidor.Libre.ToString())
            {
                filaActual.SEmpleado2.Estado = EstadoServidor.Ocupado.ToString();
                filaActual.SEmpleado1.Estado = filaAnterior.SEmpleado1.Estado;
                filaActual.SEmpleado2.Cliente_Num = filaActual.NumCliente;
                lstOrdenSE2.Add(filaActual.SEmpleado2.Cliente_Num.ToString());
                GenerarProximoFinDeAtencionServidorEmpleado(filaActual,2);
                montecarlo(filaActual, filaAnterior);
                

            }
            else
            {              
                reaprovisionamiento(filaActual);
                filaActual.SEmpleado2.Estado = filaAnterior.SEmpleado2.Estado;
                filaActual.SEmpleado1.Estado = filaAnterior.SEmpleado1.Estado;
                filaActual.ColaClientes = filaAnterior.ColaClientes + 1;

                if (!hayStock(filaAnterior))
                {
                    lstHoraEntradaCola.Add(filaActual.Reloj);
                    pasaronCincoMin(filaActual);

                }
                    
                

                filaActual.SEmpleado2.Cliente_Num = filaAnterior.SEmpleado2.Cliente_Num;
                filaActual.SEmpleado1.Cliente_Num = filaAnterior.SEmpleado1.Cliente_Num;
            }
           
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mensajeError = "";
            cantidad = 0;
            btnLimpiar.Enabled = false;
            txtDesde.Text = "";
            txtHasta.Text = "";
            txtCantidad.Text = "";
            dgvResultados.DataSource = null;
            dgvEuler.DataSource = null;
            listaMostrar = new List<VectorEstadoMostrar>();
            
         
            tablaEuler = new List<TablaEuler>();
            tablaRK = new List<TablaRK>();
            
            dgvRK.DataSource = null;
            
            objGen = new Generador();
            objRandom = new Random();
            minimo = 0;
            filaAnterior = new VectorEstado();
            
            x = 0;      
            numCliente = 0;
            stock = 0;
            FlagPrimerTiempo = false;
            EncenderHorno = false;
           
        }







        private bool hayStock(VectorEstado filaAnterior)
        {
            if (filaAnterior.Stock > 0)
                return true;
            return false;
        }

        private void montecarlo(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            //Obtencion de demanda cliente
            filaActual.RndDemandaCliente = objRandom.NextDouble();
            
            if (filaActual.RndDemandaCliente <= 0.323333333)
                filaActual.DemandaCliente = 1;
            else if (filaActual.RndDemandaCliente <= 0.656666667)
                filaActual.DemandaCliente = 2;
            else
                filaActual.DemandaCliente = 3;

            //Venta 
            if (filaAnterior.Stock <= filaActual.DemandaCliente)
                filaActual.Venta = filaAnterior.Stock; 
            else
                filaActual.Venta = filaActual.DemandaCliente;

            //Stock
            filaActual.Stock = filaAnterior.Stock - filaActual.Venta;

            reaprovisionamiento(filaActual);
           
                  


        }

        private void reaprovisionamiento(VectorEstado filaActual)
        {
            //Reaprovisionamiento
            
            double P = 45;

            if (filaAnterior.SHorno.Estado == EstadoServidor.Libre.ToString())
            {
                if (EncenderHorno == true || filaActual.Stock == 0)
                {
                    EncenderHorno = false;
                    filaActual.SHorno.Estado = EstadoServidor.Ocupado.ToString();
                    if (filaActual.Stock > 0)
                    {
                        P = 30;
                    }

                    if (opcEuler.Checked)
                    {
                        EulerSolver solver = new EulerSolver(P, h, temp_inicial);
                        solver.resolverED();
                        filaActual.SHorno.TiempoAtencion = solver.FindTime(fin_coccion);
                        if (FlagPrimerTiempo)
                            tablaEuler = solver.getTablaEuler();
                    }
                    else
                    {
                        RungeKuttaSolver solver = new RungeKuttaSolver(P, h, temp_inicial);
                        solver.resolverED();
                        filaActual.SHorno.TiempoAtencion = solver.FindTime(fin_coccion);
                        if (FlagPrimerTiempo)
                            tablaRK = solver.getTablaRK();
                    }

                    filaActual.Reap = true;
                    filaActual.CantReap = (int)P;
                    filaActual.SHorno.ProximoFinAtencion = (double)filaActual.Reloj + (double)filaActual.SHorno.TiempoAtencion;

                }
                else
                {
                    filaActual.Reap = false;
                    filaActual.CantReap = filaAnterior.CantReap;
                }

            }
        }

        private void GenerarProximoFinDeAtencionServidorEmpleado(VectorEstado fila, int servidor)
        {
          
            if (servidor == 1)
            {
                fila.SEmpleado1.Rnd = objRandom.NextDouble();
                fila.SEmpleado1.TiempoAtencion = objGen.generarUniforme(a,b, (double)fila.SEmpleado1.Rnd);
                fila.SEmpleado1.ProximoFinAtencion = (double)fila.Reloj + (double)fila.SEmpleado1.TiempoAtencion;

            }
                
            else
            {
                fila.SEmpleado2.Rnd = objRandom.NextDouble();
                fila.SEmpleado2.TiempoAtencion = objGen.generarUniforme(a,b, (double)fila.SEmpleado2.Rnd);
                fila.SEmpleado2.ProximoFinAtencion = (double)fila.Reloj + (double)fila.SEmpleado2.TiempoAtencion;

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
