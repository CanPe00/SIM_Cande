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

namespace TP5_SIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string mensajeError = "";
        enum TipoEvento { Inicio = 1, LlegadaPedido = 2, FinAct1 = 3, FinAct2 = 4, FinAct3 = 5, FinAct4 = 6, FinAct5 = 7, Paso1Hora = 8, Fin = 9 }
        enum EstadoServidor { Libre = 1, Ocupado = 2}
        Generador objGen = new Generador();
        Random objRandom = new Random();
        double minimo = 0;
        List<VectorEstadoMostrar> listaMostrar = new List<VectorEstadoMostrar>();
        VectorEstado filaAnterior = new VectorEstado();
        public int contadorCantidadEnsamblesRealizados = 0;
        public int contadorCantidadEnsamblesSolicitados = 0;
        public int CantMaxColaS1 = 0;
        public int CantMaxColaS2 = 0;
        public int CantMaxColaS3 = 0;
        public int CantMaxColaS4 = 0;
        public int CantMaxColaS5_S2 = 0;
        public int CantMaxColaS5_S4 = 0;
        public int CantMaxEnsamble_Deposito_S3 = 0;
        public int CantMaxEnsamble_Deposito_S5 = 0;
        public double TiempoOcupadoS1 = 0;
        public double TiempoLibreS1 = 0;
        public double TiempoOcupadoS2 = 0;
        public double TiempoLibreS2 = 0;
        public double TiempoOcupadoS3 = 0;
        public double TiempoLibreS3 = 0;
        public double TiempoOcupadoS4 = 0;
        public double TiempoLibreS4 = 0;
        public double TiempoOcupadoS5 = 0;
        public double TiempoLibreS5 = 0;
        public double cantPromEnsamHora = 0;
        private int cantEnsamHora = 0;
        private double hora = 0;
        private double x = 60;
        private int masDe3Ensambles = 0;
        private int cantProductosSistema = 0;
        private int cantTotalProdcutosSistema = 0;
        double tiempoOcupacionS5 = 0;
        double tiempoBloqueoS5 = 0;
        int contadorBloqueoS2 = 0;
        int contadorBloqueoS4 = 0;
        double tiempoEsperaS3 = 0;
        double tiempoEsperaS5 = 0;
        public double tiempoPromEnsamble = 0;
        public double tiempoProm = 0;

        public double tiempoColaS1 = 0;
        public double tiempoColaS2 = 0;
        public double tiempoColaS3 = 0;
        public double tiempoColaS4 = 0;
        public double tiempoColaS5_S2 = 0;
        public double tiempoColaS5_S4 = 0;
        public double tiempoColaDeposito_S3 = 0;
        public double tiempoColaDeposito_S5 = 0;

        public double tiempoPermanenciaColaS1 = 0;
        public double tiempoPermanenciaColaS2 = 0;
        public double tiempoPermanenciaColaS3 = 0;
        public double tiempoPermanenciaColaS4 = 0;
        public double tiempoPermanenciaColaS5_S2 = 0;
        public double tiempoPermanenciaColaS5_S4 = 0;
        public double tiempoPermanenciaColaDeposito_S3 = 0;
        public double tiempoPermanenciaColaDeposito_S5 = 0;


        private void btnSimular_Click(object sender, EventArgs e)
        {
            string mensajeError = "";
            if (ValidarDatos(ref mensajeError))
            {
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                for (int i = 0; i < cantidad; i++)
                {
                    VectorEstado filaActual = new VectorEstado();
                    filaActual.LlegadaPedido = new Pedido();
                    filaActual.Servidor1 = new Servidor();
                    filaActual.Servidor2 = new Servidor();
                    filaActual.Servidor3 = new Servidor();
                    filaActual.Servidor4 = new Servidor();
                    filaActual.Servidor5 = new Servidor();
                    filaActual.Ensamble = new Ensamble();


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
                        filaActual.Pedido = filaActual.TipoEvento.ToString() == TipoEvento.LlegadaPedido.ToString() ? filaAnterior.Pedido + 1 : filaAnterior.Pedido;
                        if (filaActual.TipoEvento.ToString() == TipoEvento.LlegadaPedido.ToString())
                        {
                            EventoLlegadaPedido(filaActual, filaAnterior);
                            contadorCantidadEnsamblesSolicitados += 1;
                            
                        }   
                        if (filaActual.TipoEvento.ToString() == TipoEvento.FinAct1.ToString())
                            EventoFinAct1(filaActual, filaAnterior);
                        if (filaActual.TipoEvento.ToString() == TipoEvento.FinAct2.ToString())
                            EventoFinAct2(filaActual, filaAnterior);
                        if (filaActual.TipoEvento.ToString() == TipoEvento.FinAct3.ToString())
                            EventoFinAct3(filaActual, filaAnterior);
                        if (filaActual.TipoEvento.ToString() == TipoEvento.FinAct4.ToString())
                            EventoFinAct4(filaActual, filaAnterior);
                        if (filaActual.TipoEvento.ToString() == TipoEvento.FinAct5.ToString())
                            EventoFinAct5(filaActual, filaAnterior);
                        if (filaActual.TipoEvento.ToString() == TipoEvento.Paso1Hora.ToString())
                            EventoPaso1Hora(filaAnterior);

                        maxColas(filaActual, filaAnterior);
                        porcentajeOcupacionServidor(filaActual, filaAnterior);
                        cantTotalProdcutosSistema += cantProductosSistema;
                        tiempoProm += filaActual.Reloj;

                    }
                    if (txtDesde.Text == "" && txtHasta.Text == "" && i < 200)
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

        private void EventoPaso1Hora(VectorEstado filaAnterior)
        {
            cantPromEnsamHora = (filaAnterior.Ensamble.CantEnsambles / hora);
            cantEnsamHora = filaAnterior.Ensamble.CantEnsambles - cantEnsamHora;
            masDe3Ensambles = cantEnsamHora >= Convert.ToInt32(txtProbabilidadEnsambles.Text) ? masDe3Ensambles + 1 : masDe3Ensambles;
        }

        private void porcentajeOcupacionServidor(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            TiempoLibreS1 = filaAnterior.Servidor1.Estado == EstadoServidor.Libre.ToString() ? TiempoLibreS1 + (filaActual.Reloj - filaAnterior.Reloj) : TiempoLibreS1;
            TiempoOcupadoS1 = filaAnterior.Servidor1.Estado == EstadoServidor.Ocupado.ToString() ? TiempoOcupadoS1 + (filaActual.Reloj - filaAnterior.Reloj) : TiempoOcupadoS1;
            TiempoLibreS2 = filaAnterior.Servidor2.Estado == EstadoServidor.Libre.ToString() ? TiempoLibreS2 + (filaActual.Reloj - filaAnterior.Reloj) : TiempoLibreS2;
            TiempoOcupadoS2 = filaAnterior.Servidor2.Estado == EstadoServidor.Ocupado.ToString() ? TiempoOcupadoS2 + (filaActual.Reloj - filaAnterior.Reloj) : TiempoOcupadoS2;
            TiempoLibreS3 = filaAnterior.Servidor3.Estado == EstadoServidor.Libre.ToString() ? TiempoLibreS3 + (filaActual.Reloj - filaAnterior.Reloj) : TiempoLibreS3;
            TiempoOcupadoS3 = filaAnterior.Servidor3.Estado == EstadoServidor.Ocupado.ToString() ? TiempoOcupadoS3 + (filaActual.Reloj - filaAnterior.Reloj) : TiempoOcupadoS3;
            TiempoLibreS4 = filaAnterior.Servidor4.Estado == EstadoServidor.Libre.ToString() ? TiempoLibreS4 + (filaActual.Reloj - filaAnterior.Reloj) : TiempoLibreS4;
            TiempoOcupadoS4 = filaAnterior.Servidor4.Estado == EstadoServidor.Ocupado.ToString() ? TiempoOcupadoS4 + (filaActual.Reloj - filaAnterior.Reloj) : TiempoOcupadoS4;
            TiempoLibreS5 = filaAnterior.Servidor5.Estado == EstadoServidor.Libre.ToString() ? TiempoLibreS5 + (filaActual.Reloj - filaAnterior.Reloj) : TiempoLibreS5;
            TiempoOcupadoS5 = filaAnterior.Servidor5.Estado == EstadoServidor.Ocupado.ToString() ? TiempoOcupadoS5 + (filaActual.Reloj - filaAnterior.Reloj) : TiempoOcupadoS5;

        } 

        private void maxColas(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            CantMaxColaS1 = filaActual.Servidor1.Cola >= CantMaxColaS1? filaActual.Servidor1.Cola : CantMaxColaS1;
            CantMaxColaS2 = filaActual.Servidor2.Cola >= CantMaxColaS2 ? filaActual.Servidor2.Cola : CantMaxColaS2;
            CantMaxColaS3 = filaActual.Servidor3.Cola >= CantMaxColaS3 ? filaActual.Servidor3.Cola : CantMaxColaS3;
            CantMaxColaS4 = filaActual.Servidor4.Cola >= CantMaxColaS4 ? filaActual.Servidor4.Cola : CantMaxColaS4;
            CantMaxColaS5_S2 = filaActual.Servidor5.Cola_Ser5_S2 >= CantMaxColaS5_S2 ? filaActual.Servidor5.Cola_Ser5_S2 : CantMaxColaS5_S2;
            CantMaxColaS5_S4 = filaActual.Servidor5.Cola_Ser5_S4 >= CantMaxColaS5_S4 ? filaActual.Servidor5.Cola_Ser5_S4 : CantMaxColaS5_S4;
            CantMaxEnsamble_Deposito_S3 = filaActual.Ensamble.Deposito_S3 >= CantMaxEnsamble_Deposito_S3 ? filaActual.Ensamble.Deposito_S3 : CantMaxEnsamble_Deposito_S3;
            CantMaxEnsamble_Deposito_S5 = filaActual.Ensamble.Deposito_S5 >= CantMaxEnsamble_Deposito_S5 ? filaActual.Ensamble.Deposito_S5 : CantMaxEnsamble_Deposito_S5;
        }
        private void seteo(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            filaActual.LlegadaPedido.Proxima_Llegada = filaAnterior.LlegadaPedido.Proxima_Llegada;
            filaActual.Servidor1.Estado = filaAnterior.Servidor1.Estado;
            filaActual.Servidor1.ProximoFinAtencion = filaAnterior.Servidor1.ProximoFinAtencion;
            filaActual.Servidor1.Materiales_NumPedido = filaAnterior.Servidor1.Materiales_NumPedido;
            filaActual.Servidor1.Cola = filaAnterior.Servidor1.Cola;
            filaActual.Servidor2.ProximoFinAtencion = filaAnterior.Servidor2.ProximoFinAtencion;
            filaActual.Servidor2.Estado = filaAnterior.Servidor2.Estado;
            filaActual.Servidor2.Materiales_NumPedido = filaAnterior.Servidor2.Materiales_NumPedido;
            filaActual.Servidor2.Cola = filaAnterior.Servidor2.Cola;
            filaActual.Servidor3.ProximoFinAtencion = filaAnterior.Servidor3.ProximoFinAtencion;
            filaActual.Servidor3.Estado = filaAnterior.Servidor3.Estado;
            filaActual.Servidor3.Materiales_NumPedido = filaAnterior.Servidor3.Materiales_NumPedido;
            filaActual.Servidor3.Cola = filaAnterior.Servidor3.Cola;
            filaActual.Servidor4.ProximoFinAtencion = filaAnterior.Servidor4.ProximoFinAtencion;
            filaActual.Servidor4.Estado = filaAnterior.Servidor4.Estado;
            filaActual.Servidor4.Materiales_NumPedido = filaAnterior.Servidor4.Materiales_NumPedido;
            filaActual.Servidor4.Cola = filaAnterior.Servidor4.Cola;
            filaActual.Servidor5.ProximoFinAtencion = filaAnterior.Servidor5.ProximoFinAtencion;
            filaActual.Servidor5.Estado = filaAnterior.Servidor5.Estado;
            filaActual.Servidor5.Materiales_NumPedido = filaAnterior.Servidor5.Materiales_NumPedido;
            filaActual.Servidor5.Cola_Ser5_S2 = filaAnterior.Servidor5.Cola_Ser5_S2;
            filaActual.Servidor5.Cola_Ser5_S4 = filaAnterior.Servidor5.Cola_Ser5_S4;
            filaActual.Ensamble.Deposito_S3 = filaAnterior.Ensamble.Deposito_S3;
            filaActual.Ensamble.Deposito_S5 = filaAnterior.Ensamble.Deposito_S5;
            filaActual.Ensamble.CantEnsambles = filaAnterior.Ensamble.CantEnsambles;
        }

        private void EventoFinAct5(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            filaActual.Ensamble.TerminoS5 = true;
            if (filaAnterior.Servidor5.Cola > 0)
            {
                filaActual.Servidor5.Estado = EstadoServidor.Ocupado.ToString();
                filaActual.Servidor5.Cola = filaAnterior.Servidor5.Cola - 1;
                filaActual.Servidor5.HoraSalidaCola = filaActual.Reloj;
                GenerarProximoFinDeAtencionServidor5(filaActual);
            }
            else
            {
                filaActual.Servidor5.Estado = EstadoServidor.Libre.ToString();
                filaActual.Servidor5.ProximoFinAtencion = 0;
            }
                

            ensamble(filaActual, filaAnterior);
        }

        private void EventoFinAct3(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            filaActual.Ensamble.TerminoS3 = true;
            if (filaAnterior.Servidor3.Cola > 0)
            {
                filaActual.Servidor3.Estado = EstadoServidor.Ocupado.ToString();
                filaActual.Servidor3.Cola = filaAnterior.Servidor3.Cola - 1;
                filaActual.Servidor3.HoraSalidaCola = filaActual.Reloj;
                GenerarProximoFinDeAtencionServidor3(filaActual);
                filaActual.Servidor3.Materiales_NumPedido = filaAnterior.Servidor3.Materiales_NumPedido + 1;
            }
            else
            {
                filaActual.Servidor3.Estado = EstadoServidor.Libre.ToString();
                filaActual.Servidor3.ProximoFinAtencion = 0;
                filaActual.Servidor3.Materiales_NumPedido = filaAnterior.Servidor3.Materiales_NumPedido;

            }
                

            ensamble(filaActual, filaAnterior);
        }

        private void ensamble(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            if (filaAnterior.Ensamble.Deposito_S3 > 0 && filaAnterior.Ensamble.Deposito_S5 > 0)                
            {                    
                filaActual.Ensamble.Deposito_S3 = filaAnterior.Ensamble.Deposito_S3 - 1;                    
                filaActual.Ensamble.Deposito_S5 = filaAnterior.Ensamble.Deposito_S5 - 1;
                filaActual.Ensamble.HoraSalidaCola_Deposito_S3 = filaActual.Reloj;
                filaActual.Ensamble.HoraSalidaCola_Deposito_S5 = filaActual.Reloj;
                filaActual.Ensamble.CantEnsambles = filaAnterior.Ensamble.CantEnsambles + 1;
                cantProductosSistema -= 1;
                               
            }
                
            else if (filaActual.Ensamble.TerminoS3 == true && filaActual.Ensamble.TerminoS5 == true)                
            {
                filaActual.Ensamble.CantEnsambles = filaAnterior.Ensamble.CantEnsambles + 1;
                cantProductosSistema -= 1;
            }
                
            else if (filaAnterior.Ensamble.Deposito_S3 > 0 && filaActual.Ensamble.TerminoS5 == true)                
            {
                filaActual.Ensamble.Deposito_S3 = filaAnterior.Ensamble.Deposito_S3 - 1;
                filaActual.Ensamble.HoraSalidaCola_Deposito_S3 = filaActual.Reloj;
                filaActual.Ensamble.CantEnsambles = filaAnterior.Ensamble.CantEnsambles + 1;
                cantProductosSistema -= 1;
            }
                
            else if (filaAnterior.Ensamble.Deposito_S5 > 0 && filaActual.Ensamble.TerminoS3 == true)              
            {
                filaActual.Ensamble.Deposito_S5 = filaAnterior.Ensamble.Deposito_S5 - 1;
                filaActual.Ensamble.HoraSalidaCola_Deposito_S5 = filaActual.Reloj;
                filaActual.Ensamble.CantEnsambles = filaAnterior.Ensamble.CantEnsambles + 1;
                cantProductosSistema -= 1;
            }
                
            else                
            {
                if (filaActual.Ensamble.TerminoS5 == true)
                {
                    filaActual.Ensamble.Deposito_S5 = filaAnterior.Ensamble.Deposito_S5 + 1;
                    tiempoEsperaS5 += filaActual.Reloj - filaAnterior.Reloj;
                    filaActual.Ensamble.HoraLlegadaCola_Deposito_S5 = filaActual.Reloj;
                }
                else
                    filaActual.Ensamble.Deposito_S5 = filaAnterior.Ensamble.Deposito_S5;

                if (filaActual.Ensamble.TerminoS3 == true)
                {
                    filaActual.Ensamble.Deposito_S3 = filaAnterior.Ensamble.Deposito_S3 + 1;
                    tiempoEsperaS3 += filaActual.Reloj - filaAnterior.Reloj;
                    filaActual.Ensamble.HoraLlegadaCola_Deposito_S3 = filaActual.Reloj;
                }  
                else
                    filaActual.Ensamble.Deposito_S3 = filaAnterior.Ensamble.Deposito_S3; 
            }
            contadorCantidadEnsamblesRealizados = filaActual.Ensamble.CantEnsambles;
        }

        private void EventoFinAct4(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            filaActual.Servidor5.TerminoS4 = true;

            if (filaAnterior.Servidor4.Cola > 0)
            {
                filaActual.Servidor4.Estado = EstadoServidor.Ocupado.ToString();
                filaActual.Servidor4.Cola = filaAnterior.Servidor4.Cola - 1;
                filaActual.Servidor4.HoraSalidaCola = filaActual.Reloj;
                GenerarProximoFinDeAtencionServidor4(filaActual);
                filaActual.Servidor4.Materiales_NumPedido = filaAnterior.Servidor4.Materiales_NumPedido + 1;
            }
            else
            {
                filaActual.Servidor4.Estado = EstadoServidor.Libre.ToString();
                filaActual.Servidor4.ProximoFinAtencion = 0;
                filaActual.Servidor4.Materiales_NumPedido = filaAnterior.Servidor4.Materiales_NumPedido;
            }
                

            servidor5(filaActual, filaAnterior);
        }

        private void EventoFinAct2(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            filaActual.Servidor5.TerminoS2 = true;
            
            if (filaAnterior.Servidor2.Cola > 0)
            {
                filaActual.Servidor2.Estado = EstadoServidor.Ocupado.ToString();
                filaActual.Servidor2.Cola= filaAnterior.Servidor2.Cola - 1;
                filaActual.Servidor2.HoraSalidaCola = filaActual.Reloj;
                GenerarProximoFinDeAtencionServidor2(filaActual);
                filaActual.Servidor2.Materiales_NumPedido = filaAnterior.Servidor2.Materiales_NumPedido + 1;
            }
            else
            {
                filaActual.Servidor2.Estado = EstadoServidor.Libre.ToString();
                filaActual.Servidor2.ProximoFinAtencion = 0;
                filaActual.Servidor2.Materiales_NumPedido = filaAnterior.Servidor2.Materiales_NumPedido;

            }
                
            
            servidor5(filaActual, filaAnterior);

         
        }

        private void servidor5(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            if (filaAnterior.Servidor5.Estado == EstadoServidor.Libre.ToString())
            {
                if (filaAnterior.Servidor5.Cola_Ser5_S2 > 0 && filaAnterior.Servidor5.Cola_Ser5_S4 > 0)
                {
                    filaActual.Servidor5.Cola_Ser5_S2 = filaAnterior.Servidor5.Cola_Ser5_S2 - 1;
                    filaActual.Servidor5.Cola_Ser5_S4 = filaAnterior.Servidor5.Cola_Ser5_S4 - 1;
                    filaActual.Servidor5.HoraSalidaCola_S5_S2 = filaActual.Reloj;
                    filaActual.Servidor5.HoraSalidaCola_S5_S4 = filaActual.Reloj;
                    filaActual.Servidor5.Estado = EstadoServidor.Ocupado.ToString();
                    filaActual.Servidor5.Materiales_NumPedido = filaAnterior.Servidor5.Materiales_NumPedido + 1;
                    tiempoOcupacionS5 += filaActual.Reloj - filaAnterior.Reloj;
                    GenerarProximoFinDeAtencionServidor5(filaActual);
                    

                }
                else if (filaActual.Servidor5.TerminoS2 == true && filaActual.Servidor5.TerminoS4 == true)
                {
                    filaActual.Servidor5.Estado = EstadoServidor.Ocupado.ToString();
                    filaActual.Servidor5.Materiales_NumPedido = filaAnterior.Servidor5.Materiales_NumPedido + 1;
                    tiempoOcupacionS5 += filaActual.Reloj - filaAnterior.Reloj;
                    GenerarProximoFinDeAtencionServidor5(filaActual);
                }
                else if (filaAnterior.Servidor5.Cola_Ser5_S2 > 0 && filaActual.Servidor5.TerminoS4 == true)
                {
                    filaActual.Servidor5.Cola_Ser5_S2 = filaAnterior.Servidor5.Cola_Ser5_S2 - 1;
                    filaActual.Servidor5.HoraSalidaCola_S5_S2 = filaActual.Reloj;
                    filaActual.Servidor5.Estado = EstadoServidor.Ocupado.ToString();
                    filaActual.Servidor5.Materiales_NumPedido = filaAnterior.Servidor5.Materiales_NumPedido + 1;
                    tiempoOcupacionS5 += filaActual.Reloj - filaAnterior.Reloj;
                    GenerarProximoFinDeAtencionServidor5(filaActual);
                }
                else if (filaAnterior.Servidor5.Cola_Ser5_S4 > 0 && filaActual.Servidor5.TerminoS2 == true)
                {
                    filaActual.Servidor5.Cola_Ser5_S4 = filaAnterior.Servidor5.Cola_Ser5_S4 - 1;
                    filaActual.Servidor5.HoraSalidaCola_S5_S4 = filaActual.Reloj;
                    filaActual.Servidor5.Estado = EstadoServidor.Ocupado.ToString();
                    filaActual.Servidor5.Materiales_NumPedido = filaAnterior.Servidor5.Materiales_NumPedido + 1;
                    tiempoOcupacionS5 += filaActual.Reloj - filaAnterior.Reloj;
                    GenerarProximoFinDeAtencionServidor5(filaActual);
                }
                else
                {
                    filaActual.Servidor5.Materiales_NumPedido = filaAnterior.Servidor5.Materiales_NumPedido;
                    if (filaActual.Servidor5.TerminoS2 == true)
                    {
                        filaActual.Servidor5.Cola_Ser5_S2 = filaAnterior.Servidor5.Cola_Ser5_S2 + 1;
                        tiempoBloqueoS5 += filaActual.Reloj - filaAnterior.Reloj;
                        contadorBloqueoS4 += 1;
                        filaActual.Servidor5.HoraLlegadaCola_S5_S2 = filaActual.Reloj;
                    }
                    else
                        filaActual.Servidor5.Cola_Ser5_S2 = filaAnterior.Servidor5.Cola_Ser5_S2;

                    if (filaActual.Servidor5.TerminoS4 == true)
                    {
                        filaActual.Servidor5.Cola_Ser5_S4 = filaAnterior.Servidor5.Cola_Ser5_S4 + 1;
                        tiempoBloqueoS5 += filaActual.Reloj - filaAnterior.Reloj;
                        contadorBloqueoS2 += 1;
                        filaActual.Servidor5.HoraLlegadaCola_S5_S4 = filaActual.Reloj;
                    }
                    else
                        filaActual.Servidor5.Cola_Ser5_S4 = filaAnterior.Servidor5.Cola_Ser5_S4;

                   
                }
            }
            else
            {
                filaActual.Servidor5.Estado = filaAnterior.Servidor5.Estado;
                filaActual.Servidor5.Materiales_NumPedido = filaAnterior.Servidor5.Materiales_NumPedido;
                if (filaActual.Servidor5.TerminoS2 == true)
                {
                    filaActual.Servidor5.Cola_Ser5_S2 = filaAnterior.Servidor5.Cola_Ser5_S2 + 1;
                    filaActual.Servidor5.HoraLlegadaCola_S5_S2 = filaActual.Reloj;
                }
                else
                    filaActual.Servidor5.Cola_Ser5_S2 = filaAnterior.Servidor5.Cola_Ser5_S2;

                if (filaActual.Servidor5.TerminoS4 == true)
                {
                    filaActual.Servidor5.Cola_Ser5_S4 = filaAnterior.Servidor5.Cola_Ser5_S4 + 1;
                    filaActual.Servidor5.HoraLlegadaCola_S5_S4 = filaActual.Reloj;
                }
                else
                    filaActual.Servidor5.Cola_Ser5_S4 = filaAnterior.Servidor5.Cola_Ser5_S4;
            }
        }

        private void EventoFinAct1(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            if(filaAnterior.Servidor1.Cola > 0)
            {
                filaActual.Servidor1.Estado = EstadoServidor.Ocupado.ToString();
                filaActual.Servidor1.Cola = filaAnterior.Servidor1.Cola - 1;
                filaActual.Servidor1.HoraSalidaCola = filaActual.Reloj;
                GenerarProximoFinDeAtencionServidor1(filaActual);
                filaActual.Servidor1.Materiales_NumPedido = filaAnterior.Servidor1.Materiales_NumPedido +1;
            }
            else
            {
                filaActual.Servidor1.Estado = EstadoServidor.Libre.ToString();
                filaActual.Servidor1.ProximoFinAtencion = 0;
                filaActual.Servidor1.Materiales_NumPedido = filaAnterior.Servidor1.Materiales_NumPedido;

            }
                


            if (filaAnterior.Servidor4.Estado == EstadoServidor.Libre.ToString())
            {
                filaActual.Servidor4.Estado = EstadoServidor.Ocupado.ToString();
                GenerarProximoFinDeAtencionServidor4(filaActual);
                filaActual.Servidor4.Materiales_NumPedido = filaAnterior.Servidor1.Materiales_NumPedido;

            }
            else
            {
                filaActual.Servidor4.Estado = filaAnterior.Servidor4.Estado;
                filaActual.Servidor4.Cola = filaAnterior.Servidor4.Cola + 1;
                filaActual.Servidor4.HoraLlegadaCola = filaActual.Reloj;
                filaActual.Servidor4.Materiales_NumPedido = filaAnterior.Servidor4.Materiales_NumPedido;
            }
        }

        private void EventoInicio(VectorEstado filaActual)
        {
            filaActual.TipoEvento = TipoEvento.Inicio.ToString();
            filaActual.Reloj = (double)0;
            filaActual.Pedido = 0;
            filaActual.Servidor1.Cola = 0;
            filaActual.Servidor1.Estado = EstadoServidor.Libre.ToString();
            filaActual.Servidor1.ProximoFinAtencion = 0;
            filaActual.Servidor2.Cola = 0;
            filaActual.Servidor2.Estado = EstadoServidor.Libre.ToString();
            filaActual.Servidor2.ProximoFinAtencion = 0;
            filaActual.Servidor3.Cola = 0;
            filaActual.Servidor3.Estado = EstadoServidor.Libre.ToString();
            filaActual.Servidor3.ProximoFinAtencion = 0;
            filaActual.Servidor4.Cola = 0;
            filaActual.Servidor4.Estado = EstadoServidor.Libre.ToString();
            filaActual.Servidor4.ProximoFinAtencion = 0;
            filaActual.Servidor5.Cola_Ser5_S2 = 0;
            filaActual.Servidor5.Cola_Ser5_S4 = 0;
            filaActual.Servidor5.Estado = EstadoServidor.Libre.ToString();
            filaActual.Servidor5.ProximoFinAtencion = 0;
            filaActual.Ensamble.Deposito_S3 = 0;
            filaActual.Ensamble.Deposito_S5 = 0;
            GenerarProximoPedido(filaActual);
        }

        private bool ValidarDatos(ref string MensajeError)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                mensajeError = "Debe ingresar una cantidad de simulaciones a generar";
                txtCantidad.Focus();
                return false;
            }
            else
                return true;
        }
        private void GenerarProximoPedido(VectorEstado fila)
        {      
            do
            {
                fila.LlegadaPedido.Rnd = objRandom.NextDouble();
                double lambda = (double)1 / (double)3;
                fila.LlegadaPedido.Tiempo_Entre_Llegadas = objGen.generarExponencial(lambda, (double)fila.LlegadaPedido.Rnd);
                //n++;
            } while (fila.LlegadaPedido.Tiempo_Entre_Llegadas < 0.1 || fila.LlegadaPedido.Tiempo_Entre_Llegadas > 30);   
            fila.LlegadaPedido.Proxima_Llegada = (double)(fila.Reloj + (double)fila.LlegadaPedido.Tiempo_Entre_Llegadas);
            

        }
        private TipoEvento GenerarProximoEvento(VectorEstado fila)
        {
            List<double> lst = new List<double>();

            
            if (fila.Reloj >= x)
            {
                x += 60;
                hora += 1;
                return TipoEvento.Paso1Hora;
            }

            if (fila.LlegadaPedido.Proxima_Llegada!= 0)
                lst.Add(fila.LlegadaPedido.Proxima_Llegada);

            if (fila.Servidor1.ProximoFinAtencion != 0)
                lst.Add(fila.Servidor1.ProximoFinAtencion);

            if (fila.Servidor2.ProximoFinAtencion != 0)
                lst.Add(fila.Servidor2.ProximoFinAtencion);

            if (fila.Servidor3.ProximoFinAtencion != 0)
                lst.Add(fila.Servidor3.ProximoFinAtencion);

            if (fila.Servidor4.ProximoFinAtencion != 0)
                lst.Add(fila.Servidor4.ProximoFinAtencion);

            if (fila.Servidor5.ProximoFinAtencion != 0)
                lst.Add(fila.Servidor5.ProximoFinAtencion);

            minimo = lst.Min();
            if (minimo == fila.LlegadaPedido.Proxima_Llegada)
                return TipoEvento.LlegadaPedido;
            else if (minimo == fila.Servidor1.ProximoFinAtencion)
                return TipoEvento.FinAct1;
            else if (minimo == fila.Servidor2.ProximoFinAtencion)
                return TipoEvento.FinAct2;
            else if (minimo == fila.Servidor3.ProximoFinAtencion)
                return TipoEvento.FinAct3;
            else if (minimo == fila.Servidor4.ProximoFinAtencion)
                return TipoEvento.FinAct4;
            else 
                return TipoEvento.FinAct5;

        }
        private void GenerarProximoFinDeAtencionServidor1(VectorEstado fila)
        {
            fila.Servidor1.Rnd = objRandom.NextDouble();
            fila.Servidor1.TiempoAtencion = objGen.generarUniforme(20, 30, (double)fila.Servidor1.Rnd);
            fila.Servidor1.ProximoFinAtencion = (double)fila.Reloj + (double)fila.Servidor1.TiempoAtencion;
        }
        private void GenerarProximoFinDeAtencionServidor2(VectorEstado fila)
        {
            fila.Servidor2.Rnd = objRandom.NextDouble();
            fila.Servidor2.TiempoAtencion = objGen.generarUniforme(30, 50, (double)fila.Servidor2.Rnd);
            if (chkDisminuir.Checked)
                fila.Servidor2.TiempoAtencion = (fila.Servidor2.TiempoAtencion - fila.Servidor2.TiempoAtencion * 0.2);
            fila.Servidor2.ProximoFinAtencion = (double)fila.Reloj + (double)fila.Servidor2.TiempoAtencion;
        }
        private void GenerarProximoFinDeAtencionServidor3(VectorEstado fila)
        {
            fila.Servidor3.Rnd = objRandom.NextDouble();
            fila.Servidor3.TiempoAtencion = objGen.generarExponencial(30, (double)fila.Servidor3.Rnd);
            fila.Servidor3.ProximoFinAtencion = (double)fila.Reloj + (double)fila.Servidor3.TiempoAtencion;
        }
        private void GenerarProximoFinDeAtencionServidor4(VectorEstado fila)
        {
            fila.Servidor4.Rnd = objRandom.NextDouble();
            fila.Servidor4.TiempoAtencion = objGen.generarUniforme(10, 20, (double)fila.Servidor4.Rnd);
            fila.Servidor4.ProximoFinAtencion = (double)fila.Reloj + (double)fila.Servidor4.TiempoAtencion;
        }
        private void GenerarProximoFinDeAtencionServidor5(VectorEstado fila)
        {
            fila.Servidor5.Rnd = objRandom.NextDouble();
            fila.Servidor5.TiempoAtencion = objGen.generarExponencial(5, (double)fila.Servidor5.Rnd);
            fila.Servidor5.ProximoFinAtencion = (double)fila.Reloj + (double)fila.Servidor5.TiempoAtencion;
        }
        private void EventoLlegadaPedido(VectorEstado filaActual, VectorEstado filaAnterior)
        {
            GenerarProximoPedido(filaActual);
            cantProductosSistema += 1;
            
            if (filaAnterior.Servidor1.Estado == EstadoServidor.Libre.ToString())
            {
                filaActual.Servidor1.Estado = EstadoServidor.Ocupado.ToString();
                filaActual.Servidor1.Materiales_NumPedido = filaAnterior.Servidor1.Materiales_NumPedido + 1;
                GenerarProximoFinDeAtencionServidor1(filaActual);
            }
            else
            {
                filaActual.Servidor1.Estado = filaAnterior.Servidor1.Estado;
                filaActual.Servidor1.Materiales_NumPedido = filaAnterior.Servidor1.Materiales_NumPedido;
                filaActual.Servidor1.Cola += 1;
                filaActual.Servidor1.HoraLlegadaCola = filaActual.Reloj;
                   
            }
            if (filaAnterior.Servidor2.Estado == EstadoServidor.Libre.ToString())
            {
                filaActual.Servidor2.Estado = EstadoServidor.Ocupado.ToString();
                filaActual.Servidor2.Materiales_NumPedido = filaAnterior.Servidor2.Materiales_NumPedido + 1;
                GenerarProximoFinDeAtencionServidor2(filaActual);
            }
            else
            {
                filaActual.Servidor2.Estado = filaAnterior.Servidor2.Estado;
                filaActual.Servidor2.Cola += 1;
                filaActual.Servidor2.HoraLlegadaCola = filaActual.Reloj;
                filaActual.Servidor2.Materiales_NumPedido = filaAnterior.Servidor2.Materiales_NumPedido;
            }
            if (filaAnterior.Servidor3.Estado == EstadoServidor.Libre.ToString())
            {
                filaActual.Servidor3.Estado = EstadoServidor.Ocupado.ToString();
                filaActual.Servidor3.Materiales_NumPedido = filaAnterior.Servidor3.Materiales_NumPedido + 1;
                GenerarProximoFinDeAtencionServidor3(filaActual);
            }
            else
            {
                filaActual.Servidor3.Estado = filaAnterior.Servidor3.Estado;
                filaActual.Servidor3.Cola += 1;
                filaActual.Servidor3.HoraLlegadaCola = filaActual.Reloj;
                filaActual.Servidor3.Materiales_NumPedido = filaAnterior.Servidor3.Materiales_NumPedido;
            }
        }
        public void tiempoPromedioPermanenciaEnCola(VectorEstado fila)
        {

            if ( fila.Servidor1.Cola > 0)
            {
                tiempoColaS1 += (fila.Servidor1.HoraSalidaCola - fila.Servidor1.HoraLlegadaCola);
                tiempoPermanenciaColaS1 = tiempoColaS1 / CantMaxColaS1;
            }

            if (fila.Servidor2.Cola > 0)
            {
                tiempoColaS2 += (fila.Servidor2.HoraSalidaCola - fila.Servidor2.HoraLlegadaCola);
                tiempoPermanenciaColaS2 = tiempoColaS2 / CantMaxColaS2;
            }

            if (fila.Servidor3.Cola > 0)
            {
                tiempoColaS3 += (fila.Servidor3.HoraSalidaCola - fila.Servidor3.HoraLlegadaCola);
                tiempoPermanenciaColaS3 = tiempoColaS3 / CantMaxColaS3;
            }

            if (fila.Servidor4.Cola > 0)
            {
                tiempoColaS4 = (fila.Servidor4.HoraSalidaCola - fila.Servidor4.HoraLlegadaCola);
                tiempoPermanenciaColaS4 = tiempoColaS4 / CantMaxColaS4;
            }

            if (fila.Servidor5.Cola > 0)
            {
                tiempoColaS5_S2 = (fila.Servidor5.HoraSalidaCola_S5_S2 - fila.Servidor5.HoraLlegadaCola_S5_S2);
                tiempoPermanenciaColaS5_S2 = tiempoColaS5_S2 / CantMaxColaS5_S2;
            }

            if (fila.Servidor5.Cola > 0)
            {
                tiempoColaS5_S4 = (fila.Servidor5.HoraSalidaCola_S5_S4 - fila.Servidor5.HoraLlegadaCola_S5_S4);
                tiempoPermanenciaColaS5_S4 = tiempoColaS5_S4 / CantMaxColaS5_S4;
            }

            if (fila.Ensamble.Deposito_S3 > 0)
            {
                tiempoColaDeposito_S3 = (fila.Ensamble.HoraSalidaCola_Deposito_S3 - fila.Ensamble.HoraLlegadaCola_Deposito_S3);
                tiempoPermanenciaColaDeposito_S3 = tiempoColaDeposito_S3 / CantMaxEnsamble_Deposito_S3;
            }

            if (fila.Ensamble.Deposito_S5 > 0)
            {
                tiempoColaDeposito_S5 = (fila.Ensamble.HoraSalidaCola_Deposito_S5 - fila.Ensamble.HoraLlegadaCola_Deposito_S5);
                tiempoPermanenciaColaDeposito_S5 = tiempoColaDeposito_S5 / CantMaxEnsamble_Deposito_S5;
            }

            
        }
        private void cargarFila(VectorEstado filaActual)
        {
            VectorEstadoMostrar filaMostrar = new VectorEstadoMostrar();
            filaMostrar.Evento = filaActual.numEvento;
            filaMostrar.TipoEvento = filaActual.TipoEvento;
            filaMostrar.Reloj = (Math.Round(filaActual.Reloj,2)).ToString();
            filaMostrar.Pedido = filaActual.Pedido;
            filaMostrar.RndPedido = Math.Round(filaActual.LlegadaPedido.Rnd,2);
            filaMostrar.TiempoEntreLlegadasPedido = Math.Round(filaActual.LlegadaPedido.Tiempo_Entre_Llegadas,2);
            filaMostrar.ProximaLlegadaPedido = Math.Round(filaActual.LlegadaPedido.Proxima_Llegada,2);
            filaMostrar.EstadoS1 = filaActual.Servidor1.Estado;
            filaMostrar.Materiales_NumPedidoS1 = filaActual.Servidor1.Materiales_NumPedido.ToString();
            filaMostrar.RndS1 = Math.Round(filaActual.Servidor1.Rnd,2);
            filaMostrar.TiempoDeAtencionS1 = Math.Round(filaActual.Servidor1.TiempoAtencion,2);
            filaMostrar.ProximoFinAtencionS1 = Math.Round(filaActual.Servidor1.ProximoFinAtencion,2);
            filaMostrar.ColaS1 = filaActual.Servidor1.Cola;
            filaMostrar.InicioAtencionS1 = Math.Round(filaActual.Servidor1.InicioAtencion,2);
            filaMostrar.EstadoS2 = filaActual.Servidor2.Estado;
            filaMostrar.Materiales_NumPedidoS2 = filaActual.Servidor2.Materiales_NumPedido.ToString();
            filaMostrar.RndS2 = Math.Round(filaActual.Servidor2.Rnd,2);
            filaMostrar.TiempoDeAtencionS2 = Math.Round(filaActual.Servidor2.TiempoAtencion,2);
            filaMostrar.ProximoFinAtencionS2 = Math.Round(filaActual.Servidor2.ProximoFinAtencion,2);
            filaMostrar.ColaS2 = filaActual.Servidor2.Cola;
            filaMostrar.InicioAtencionS2 = Math.Round(filaActual.Servidor2.InicioAtencion,2);
            filaMostrar.EstadoS3 = filaActual.Servidor3.Estado;
            filaMostrar.Materiales_NumPedidoS3 = filaActual.Servidor3.Materiales_NumPedido.ToString();
            filaMostrar.RndS3 = Math.Round(filaActual.Servidor3.Rnd,2);
            filaMostrar.TiempoDeAtencionS3 = Math.Round(filaActual.Servidor3.TiempoAtencion,2);
            filaMostrar.ProximoFinAtencionS3 = Math.Round(filaActual.Servidor3.ProximoFinAtencion,2);
            filaMostrar.ColaS3 = filaActual.Servidor3.Cola;
            filaMostrar.InicioAtencionS3 = Math.Round(filaActual.Servidor3.InicioAtencion,2);
            filaMostrar.EstadoS4 = filaActual.Servidor4.Estado;
            filaMostrar.Materiales_NumPedidoS4 = filaActual.Servidor4.Materiales_NumPedido.ToString();
            filaMostrar.RndS4 = Math.Round(filaActual.Servidor4.Rnd,2);
            filaMostrar.TiempoDeAtencionS4 = Math.Round(filaActual.Servidor4.TiempoAtencion,2);
            filaMostrar.ProximoFinAtencionS4 = Math.Round(filaActual.Servidor4.ProximoFinAtencion,2);
            filaMostrar.ColaS4 = filaActual.Servidor4.Cola;
            filaMostrar.InicioAtencionS4 = Math.Round(filaActual.Servidor4.InicioAtencion,2);
            filaMostrar.EstadoS5 = filaActual.Servidor5.Estado;
            filaMostrar.Materiales_NumPedidoS5 = filaActual.Servidor5.Materiales_NumPedido.ToString();
            filaMostrar.RndS5 = Math.Round(filaActual.Servidor5.Rnd,2);
            filaMostrar.TiempoDeAtencionS5 = Math.Round(filaActual.Servidor5.TiempoAtencion,2);
            filaMostrar.ProximoFinAtencionS5 = Math.Round(filaActual.Servidor5.ProximoFinAtencion,2);
            filaMostrar.ColaS5_S2 = filaActual.Servidor5.Cola_Ser5_S2;
            filaMostrar.ColaS5_S4 = filaActual.Servidor5.Cola_Ser5_S4;
            filaMostrar.InicioAtencionS5 = Math.Round(filaActual.Servidor5.InicioAtencion,2);
            filaMostrar.Ensamble_Deposito_S3 = filaActual.Ensamble.Deposito_S3;
            filaMostrar.Ensamble_Deposito_S5 = filaActual.Ensamble.Deposito_S5;
            filaMostrar.CantidadEnsamblesTotal = filaActual.Ensamble.CantEnsambles;
            filaMostrar.CantMaxColaS1 = CantMaxColaS1;
            filaMostrar.CantMaxColaS2 = CantMaxColaS2;
            filaMostrar.CantMaxColaS3 = CantMaxColaS3;
            filaMostrar.CantMaxColaS4 = CantMaxColaS4;
            filaMostrar.CantMaxColaS5_S2 = CantMaxColaS5_S2;
            filaMostrar.CantMaxColaS5_S4 = CantMaxColaS5_S4;
            filaMostrar.CantMaxEnsamble_Deposito_S3 = CantMaxEnsamble_Deposito_S3;
            filaMostrar.CantMaxEnsamble_Deposito_S5 = CantMaxEnsamble_Deposito_S5;
            filaMostrar.CantidadEnsamblesPromedioXhr = Math.Round(cantPromEnsamHora,3);
            filaMostrar.CantidadEnsamblesXHr = cantEnsamHora;
            filaMostrar.CantidadProductosSistema = cantProductosSistema ;

            listaMostrar.Add(filaMostrar);

        }
        private void cargarGrilla()
        {
            dgvResultados.DataSource = listaMostrar;
            dgvResultados.Refresh();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos(bool cambiaOpcion = false)
        {
            btnLimpiar.Enabled = false;
            txtCantidad.Text = "";
            dgvResultados.DataSource = null;
            listaMostrar = new List<VectorEstadoMostrar>();

        }
        private TimeSpan convertirAMinutos(double reloj)
        {
            return TimeSpan.FromMinutes(reloj);
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrarEstadisticas_Click(object sender, EventArgs e)
        {
            frmResultados formEstadisticas = new frmResultados();
            formEstadisticas.lblPropEnsambles.Text = (((double)contadorCantidadEnsamblesRealizados * (double)100) / (double)contadorCantidadEnsamblesSolicitados).ToString("n2") + "%";
            formEstadisticas.lblEnsamblesRealizados.Text = contadorCantidadEnsamblesRealizados.ToString();
            formEstadisticas.lblEnsamblesSolicitados.Text = contadorCantidadEnsamblesSolicitados.ToString();
            formEstadisticas.lblCantMaxColaS1.Text = CantMaxColaS1.ToString();
            formEstadisticas.lblCantMaxColaS2.Text = CantMaxColaS2.ToString();
            formEstadisticas.lblCantMaxS3.Text = CantMaxColaS3.ToString();
            formEstadisticas.lblCantMaxS4.Text = CantMaxColaS4.ToString();
            formEstadisticas.lblCantMaxS5S2.Text = CantMaxColaS5_S2.ToString();
            formEstadisticas.lblCantMaxS5S4.Text = CantMaxColaS5_S4.ToString();
            formEstadisticas.lblCantMaxEnsambleS3.Text = CantMaxEnsamble_Deposito_S3.ToString();
            formEstadisticas.lblCantMaxEnsambleS5.Text = CantMaxEnsamble_Deposito_S5.ToString();
            formEstadisticas.lblPorcOcupS1.Text= (TiempoOcupadoS1==0 && TiempoLibreS1==0) ? 0.ToString("n2") + "%" : (TiempoOcupadoS1 * (double)100 / (TiempoLibreS1 + TiempoOcupadoS1)).ToString("n2") + "%";
            formEstadisticas.lblTLS1.Text = Math.Round(TiempoLibreS1,2).ToString();
            formEstadisticas.lblTOS1.Text = Math.Round(TiempoOcupadoS1, 2).ToString();
            formEstadisticas.lblPorcOcupS2.Text = (TiempoOcupadoS2 == 0 && TiempoLibreS2 == 0) ? 0.ToString("n2") + "%" : ((TiempoOcupadoS2 * (double)100) / (TiempoLibreS2 + TiempoOcupadoS2)).ToString("n2") + "%";
            formEstadisticas.lblTLS2.Text = Math.Round(TiempoLibreS2, 2).ToString();
            formEstadisticas.lblTOS2.Text = Math.Round(TiempoOcupadoS2, 2).ToString();
            formEstadisticas.lblPorcOcupS3.Text = (TiempoOcupadoS3 == 0 && TiempoLibreS3 == 0) ? 0.ToString("n2") + "%" : ((TiempoOcupadoS3 * (double)100) / (TiempoLibreS3 + TiempoOcupadoS3)).ToString("n2") + "%";
            formEstadisticas.lblTLS3.Text = Math.Round(TiempoLibreS3, 2).ToString();
            formEstadisticas.lblTOS3.Text = Math.Round(TiempoOcupadoS3, 2).ToString();
            formEstadisticas.lblPorcOcupS4.Text = (TiempoOcupadoS4 == 0 && TiempoLibreS4 == 0) ? 0.ToString("n2") + "%" : ((TiempoOcupadoS4 * (double)100) / (TiempoLibreS4 + TiempoOcupadoS4)).ToString("n2") + "%";
            formEstadisticas.lblTLS4.Text = Math.Round(TiempoLibreS4, 2).ToString();
            formEstadisticas.lblTOS4.Text = Math.Round(TiempoOcupadoS4, 2).ToString();
            formEstadisticas.lblPorcOcupS5.Text = (TiempoOcupadoS5 == 0 && TiempoLibreS5 == 0) ? 0.ToString("n2") + "%" : ((TiempoOcupadoS5 * (double)100) / (TiempoLibreS5 + TiempoOcupadoS5)).ToString("n2") + "%";
            formEstadisticas.lblTLS5.Text = Math.Round(TiempoLibreS5, 2).ToString();
            formEstadisticas.lblTOS5.Text = Math.Round(TiempoOcupadoS5, 2).ToString();
            formEstadisticas.lblProb3oMas.Text = ((masDe3Ensambles * 100) / hora).ToString("n2") + "%";
            formEstadisticas.lblCantPromProdSis.Text = (cantTotalProdcutosSistema / Convert.ToInt32(txtCantidad.Text)).ToString();
            formEstadisticas.lblPromedioEnsamblesXHora.Text = Math.Round(cantPromEnsamHora,2).ToString();
            formEstadisticas.lblBloqueoOcupaS5.Text = (tiempoBloqueoS5 * (double)100 / (tiempoBloqueoS5 + tiempoOcupacionS5)).ToString("n2") + "%";
            formEstadisticas.lblSeccionBloqueante.Text = contadorBloqueoS2 > contadorBloqueoS4 ? "Sección 2" : "Sección 4";
            formEstadisticas.lblTiempoTotalEsperaEnsamble.Text = (tiempoEsperaS3 + tiempoEsperaS5).ToString("n2");
            formEstadisticas.lblTiempoEsperaS3.Text = (tiempoEsperaS3 * 100 / (tiempoEsperaS3 + tiempoEsperaS5)).ToString() + "%";
            formEstadisticas.lblTiempoEsperaS5.Text = (tiempoEsperaS5 * 100 / (tiempoEsperaS3 + tiempoEsperaS5)).ToString() + "%";
            formEstadisticas.lblTiempoPromE.Text = Math.Round((tiempoProm/cantProductosSistema), 2).ToString();
            formEstadisticas.ShowDialog();
            
        }

        private void chkDisminuir_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
