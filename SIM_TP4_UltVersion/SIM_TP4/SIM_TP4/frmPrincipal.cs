using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SIM_TP4
{
    public partial class Form1 : Form
    {
        bool actTodasCargadas = false;
        Generador objGen = new Generador();
        double valor_a_unif1, valor_b_unif1, valor_a_unif_2, valor_b_unif2, valor_a_unif_4, valor_b_unif_4 = 0;
        double valor_lambda3, valor_lambda5 = 0;
        double valor_u, valor_s = 0;
        double nodo1, nodo2, nodo3 = 0;
        double duracion_promedio_anterior = 0;
        double varianza_anterior = 0;
        List<Fila> lstMostrar = new List<Fila>();
        frmGraficos objGrafico = new frmGraficos();
        double maximo = 0;
        double minimo = 0;
        double probabilidad_anterior = 0;
        double probabilidad = 0;
        int validar = 0;
        List<Fila> lstPrimeras14Sim = new List<Fila>();
        List<Intervalo> lstIntervalos = new List<Intervalo>();
        double porcentaje_anterior = 0;
        string mensaje = "";
        double act1Critica = 0;
        double act2Critica = 0;
        double act3Critica = 0;
        double act4Critica = 0;
        double act5Critica = 0;
        double tiempoTardioAct1 = 0;
        double tiempoTardioAct2 = 0;
        double tiempoTardioAct3 = 0;
        double tiempoTardioAct4 = 0;
        double tiempoTardioAct5 = 0;
        double ultima_duracion_promedio, ultima_fecha_nc90 = 0;

        public Form1()
        {
            InitializeComponent();
           

        }
        enum Actividades
        {
            Act_1 = 0,
            Act_2 = 1,
            Act_3 = 2,
            Act_4 = 3,
            Act_5 = 4
        }
        private void cboDistribucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarCampos(true);
            if (cboDistribucion.SelectedIndex == 0)
            {
                txt_Unif_a.Enabled = txt_Unif_b.Enabled = true;
                txt_normal_u.Enabled = txt_normal_s.Enabled = txtLambda.Enabled = false;
            }
            if (cboDistribucion.SelectedIndex == 1)
            {
                txt_Unif_a.Enabled = txt_Unif_b.Enabled = txt_normal_u.Enabled = txt_normal_s.Enabled = false;
                txtLambda.Enabled = true;
            }
            if (cboDistribucion.SelectedIndex == 2)
            {
                txt_Unif_a.Enabled = txt_Unif_b.Enabled = txtLambda.Enabled = false;
                txt_normal_u.Enabled = txt_normal_s.Enabled  = true;
            }
            txt_Unif_a.Text = "";
            txt_Unif_b.Text = "";
            txt_normal_u.Text = "";
            txt_normal_s.Text = "";
            txtLambda.Text = "";

        }
        private void limpiarCampos(bool cambiaDistribucion = false)
        {
            if (!cambiaDistribucion)
                cboDistribucion.SelectedIndex = -1;
            txt_Unif_a.Text = "";
            txt_Unif_b.Text = "";
            txt_normal_u.Text = "";
            txt_normal_s.Text = "";
            btnLimpiar.Enabled = false;
            lstMostrar = new List<Fila>();
            grdPlantilla.DataSource = null;
            txtCantSim.Text = "";
            lblMin.Text = "";
            lblMax.Text = "";
            lblDuracionPromedio.Text = "";
            lblTiempoSimulacion.Text = "";
            lblProbabilidad.Text = "";
            lblFechaNC.Text = "";
            lblFechaNCIntervalos.Text = "";
            lblAct1Critica.Text = "";
            lblAct2Critica.Text = "";
            lblAct3Critica.Text = "";
            lblAct4Critica.Text = "";
            lblAct5Critica.Text = "";
            lblttAct1.Text = "";
            lblttAct2.Text = "";
            lblttAct3.Text = "";
            lblttAct4.Text = "";
            lblttAct5.Text = "";
            cboActividades.SelectedIndex = 0;
            txtDesde.Text = "";
            txtHasta.Text = "";
            lstPrimeras14Sim = new List<Fila>();
            lstIntervalos = new List<Intervalo>();


        }

        private void cboActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            double numero1 = -1;
            double numero2 = 0;
            switch (cboActividades.SelectedIndex)
            {
                case 0:
                    //rellenar los campos con la info por defecto para la Act 1
                    cboDistribucion.SelectedIndex = 0; //Dist Uniforme
                    txt_Unif_a.Text = "20";
                    txt_Unif_b.Text = "30";
                    valor_a_unif1 = Convert.ToDouble(txt_Unif_a.Text);
                    valor_b_unif1 = Convert.ToDouble(txt_Unif_b.Text);
                    break;
                case 1:
                    //rellenar los campos con la info por defecto para la Act 2
                    cboDistribucion.SelectedIndex = 0; //Dist Uniforme
                    txt_Unif_a.Text = "30";
                    txt_Unif_b.Text = "50";
                    valor_a_unif_2 = Convert.ToDouble(txt_Unif_a.Text);
                    valor_b_unif2 = Convert.ToDouble(txt_Unif_b.Text);
                    break;
                case 2:
                    //rellenar los campos con la info por defecto para la Act 3
                    cboDistribucion.SelectedIndex = 1; //Dist Exponencial
                    numero2 = 30;
                    double valor_lambda = Math.Round((numero1/numero2),3);
                    txtLambda.Text = $"{valor_lambda}";
                    valor_lambda3 = Convert.ToDouble(txtLambda.Text);
                    break;
                case 3:
                    //rellenar los campos con la info por defecto para la Act 4
                    cboDistribucion.SelectedIndex = 0; //Dist Uniforme
                    txt_Unif_a.Text = "10";
                    txt_Unif_b.Text = "20";
                    valor_a_unif_4 = Convert.ToDouble(txt_Unif_a.Text);
                    valor_b_unif_4 = Convert.ToDouble(txt_Unif_b.Text);
                    break;
                case 4:
                    //rellenar los campos con la info por defecto para la Act 5
                    cboDistribucion.SelectedIndex = 1; //Dist Exponencial
                    numero2 = 5;
                    double valor_lambda2 = Math.Round((numero1/numero2),3);
                    txtLambda.Text = $"{valor_lambda2}";
                    valor_lambda5 = Convert.ToDouble(txtLambda.Text);
                    actTodasCargadas = true;
                    break;
            }
            habilitarBtnGenerar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void habilitarBtnGenerar()
        {
            string mensajeError = "";
            if (actTodasCargadas)
                btnCalcular.Enabled = true;

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            objGrafico.ShowDialog();

        }

        private bool ValidarDatosDistUnif(ref string mensajeError)
        {

            if (cboDistribucion.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txt_Unif_a.Text))
                {
                    mensajeError = "Debe ingresar un valor para a";
                    txt_Unif_a.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(txt_Unif_b.Text))
                {
                    mensajeError = "Debe ingresar un valor para b";
                    txt_Unif_b.Focus();
                    return false;
                }
                else if ((Convert.ToDouble(txt_Unif_a.Text) > Convert.ToDouble(txt_Unif_b.Text)))
                {
                    mensajeError = "El parámetro a de la Distribución Uniforme no puede ser mayor a b";
                    return false;
                }

            }
            return true;
        }
        private bool ValidarDatosDistExp(ref string mensajeError)
        {
            if(cboDistribucion.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txtLambda.Text))
                {
                    mensajeError = "Debe ingresar un valor para lambda";
                    txtLambda.Focus();
                    return false;
                }
                else if ((Convert.ToDouble(txtLambda.Text) <= 0))
                {
                    mensajeError = "El parámetro lambda debe ser mayor a cero";
                    return false;
                }
            }
            return true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarDatosDistNormal(ref string mensajeError)
        {

            if (cboDistribucion.SelectedIndex == 2)
            {
                if (string.IsNullOrEmpty(txt_normal_s.Text))
                {
                    mensajeError = "Debe ingresar un valor para s";
                    txt_normal_s.Focus();
                    return false;
                }
                else if ((Convert.ToDouble(txt_normal_s.Text) < 0))
                {
                    mensajeError = "El parámetro desviación estandar debe ser mayor o igual a cero";
                    return false;
                }
            }
            return true;
        }

        private bool ValidarDatos(ref string mensajeError)
        {

            if (string.IsNullOrEmpty(txtCantSim.Text))
            {
                mensajeError = "Debe ingresar una cantidad de simulaciones a generar";
                txtCantSim.Focus();
                return false;
            }
            else
            {
                int cantidad = 0;

                if (!int.TryParse(txtCantSim.Text, out cantidad))
                {
                    mensajeError = "La cantidad debe ser un número entero";
                    return false;
                }

                if (cantidad % 1 != 0)
                {
                    mensajeError = "La cantidad debe ser un número entero";
                    return false;
                }

                if (cantidad <= 0)
                {
                    mensajeError = "La cantidad debe ser un número mayor a cero";
                    return false;
                }

            }
            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            string mensajeError = "";
            if (ValidarDatos(ref mensajeError)) {
                
                
                int cantidadSim = Convert.ToInt32(txtCantSim.Text);
                Stopwatch reloj = new Stopwatch();
                reloj.Start();
                for (int i = 0; i < cantidadSim; i++)
                {
                
                    Fila objFila = new Fila();
                    objFila.numero_Simulacion = i;
                    objFila.rand1 = objRandom.NextDouble();
                    objFila.rand2 = objRandom.NextDouble();
                    objFila.rand3 = objRandom.NextDouble();
                    objFila.rand4 = objRandom.NextDouble();
                    objFila.rand5 = objRandom.NextDouble();
                    objFila.duracion1 = objGen.generarUniforme(valor_a_unif1, valor_b_unif1, objFila.rand1);
                    objFila.duracion2 = objGen.generarUniforme(valor_a_unif_2, valor_b_unif2, objFila.rand2);
                    objFila.duracion3 = (objGen.generarExponencial(valor_lambda3, objFila.rand3))*-1;
                    objFila.duracion4 = objGen.generarUniforme(valor_a_unif_4, valor_b_unif_4, objFila.rand4);
                    objFila.duracion5 = (objGen.generarExponencial(valor_lambda5, objFila.rand5))*-1;
                    objFila.nodo1 = calcularNodo1(objFila.duracion1);
                    objFila.nodo2 = calcularNodo2(objFila.duracion2, objFila.duracion4);
                    objFila.nodo3 = calcularNodo3(objFila.duracion3, objFila.duracion5);
                    objFila.duracion_promedio = calcularDuracionPromedio(i, objFila.nodo3);
                    objFila.varianza = calcularVarianza(i, varianza_anterior, objFila.duracion_promedio, objFila.nodo3);
                    duracion_promedio_anterior = objFila.duracion_promedio;
                    varianza_anterior = objFila.varianza;
                    objFila.desviacion = Math.Sqrt(objFila.varianza);
                    objFila.fecha_nc_90 = calcularFechaNivelConfianza90(i, objFila.duracion_promedio, objFila.desviacion);
                    if (i <= 13)
                        lstPrimeras14Sim.Add(objFila);
                    if (i >= 14)
                    {
                        if (i == 14)
                        {
                            armarIntervalosDeFrecuencias(lstPrimeras14Sim);
                        }
                        calcularFrecuenciasObservadas(objFila.nodo3);
                    }  
                    if (i == 0)
                    {
                        maximo = objFila.nodo3;
                        minimo = objFila.nodo3;
                    }
                    else
                    {
                        if (objFila.nodo3 < minimo)
                            minimo = objFila.nodo3;
                        if (objFila.nodo3 > maximo)
                            maximo = objFila.nodo3;
                    }
                    validar = objFila.nodo3 <= Convert.ToDouble(45) ? 1 : 0;
                    probabilidad = ((probabilidad_anterior * i) + validar) / (i + 1);
                    probabilidad_anterior = probabilidad;
                    validar = 0;
                    if (i == cantidadSim - 1)
                    {

                        ultima_fecha_nc90 = objFila.fecha_nc_90;
                        ultima_duracion_promedio = objFila.duracion_promedio;

                    }
                    if (txtDesde.Text == "" && txtHasta.Text == "" && !checkListarMultiplos.Checked && i < 20)
                        lstMostrar.Add(objFila);
                    else if (txtDesde.Text != "" && txtDesde.Text != "" && !checkListarMultiplos.Checked && i >= Convert.ToInt32(txtDesde.Text) && i <= Convert.ToInt32(txtHasta.Text))
                        lstMostrar.Add(objFila);
                    else if (txtDesde.Text == "" && txtHasta.Text == "" && checkListarMultiplos.Checked && (i % 10000 == 0))
                        lstMostrar.Add(objFila);
                    if (cantidadSim > 20 && i % (cantidadSim / Convert.ToDouble((cantidadSim * 1 / 100))) == 0)
                        objGrafico.grafico.Series["DuracionPromedio"].Points.Add(objFila.duracion_promedio, i);
                    else
                        objGrafico.grafico.Series["DuracionPromedio"].Points.Add(objFila.duracion_promedio, i);
                }
                reloj.Stop();
                lblTiempoSimulacion.Text = reloj.Elapsed.TotalSeconds.ToString();
                calcularPorcentajes();
                cargarDatosLabels();
                cargarGrilla();
               
                btnLimpiar.Enabled = true;
                
            }
            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK);
            }

        }

        private double calcularFechaNivelConfianza90(int i, double duracion_promedio, double desviacion)
        {
            double i_double = Convert.ToDouble(i);
            double probabilidad = Convert.ToDouble(1 - 0.9);
            if (i > 1)
            {
                int gdl = i - 1;
                double segundo_termino = MathNet.Numerics.ExcelFunctions.TInv(probabilidad, gdl);
                return duracion_promedio + (segundo_termino * (desviacion / Math.Sqrt(i_double)));
            } 
            else
                return 0;
        }
        private double calcularDuracionPromedio(int i, double filanodo3)
        {
            double termino1 = Convert.ToDouble(1) / (Convert.ToDouble(i + 1));
            return termino1 * ((Convert.ToDouble(i) * duracion_promedio_anterior) + filanodo3);
        }
      

        private double calcularNodo1(double duracion1)
        {
            nodo1 = duracion1;
            return nodo1;
        }
        private double calcularNodo2(double duracion2, double duracion4)
        {
            
            List<double> lstValores = new List<double>();
            lstValores.Add(duracion2);
            lstValores.Add(duracion4 + nodo1);
            nodo2 = lstValores.Max();
            if( nodo2 == duracion2)
            {
                act2Critica += 1;
                double t1=(duracion2 - (nodo1 + duracion4));
                double t4= (duracion2 - (duracion4 + nodo1));
                

                if (tiempoTardioAct1 < t1 && t1 >0 ) {
                    tiempoTardioAct1 = t1;
                }
                if(tiempoTardioAct4 < t4 && t4 > 0)
                {
                    tiempoTardioAct4 = t4;

                }                          
            }
            else
            {
                double t2 = ((duracion4 + nodo1) - duracion2);
                act1Critica += 1;
                act4Critica += 1;

                if(tiempoTardioAct2 < t2 && t2 > 0)
                {
                    tiempoTardioAct2 = t2;
                }
                
            }
            return nodo2;
        }
        private double calcularNodo3(double duracion3, double duracion5)
        {
            List<double> lstValores = new List<double>();
            lstValores.Add(duracion3);
            lstValores.Add(duracion5 + nodo2);
            nodo3 = lstValores.Max();
            if (nodo2 == duracion3)
            {
                double t5 = (duracion3 - (duracion5 + nodo2));

                act3Critica += 1;
     
                if (tiempoTardioAct5 < t5 && t5 > 0)
                {
                    tiempoTardioAct5 = t5;
                }
            }
            else
            {
                double t3 = ((duracion5 + nodo2) - duracion3);
                act5Critica += 1;
                if (tiempoTardioAct3 < t3 && t3 > 0)
                {
                    tiempoTardioAct3 = t3;
                }
           
            }
            return nodo3;
        }
        private double calcularVarianza(int i, double varianza_anterior, double duracion_promedio, double nodo3)
        {
            double i_double = Convert.ToDouble(i);
            if (i <= 1)
                return 0;
            else
            {
                double uno = Convert.ToDouble(1);
                double primer_factor = uno / (i_double - uno);
                double primer_termino_corchete = (i_double - Convert.ToDouble(2)) * varianza_anterior;
                double dif_cuadrada_duracion = Math.Pow((duracion_promedio - nodo3),2);
                double segundo_termino_corchete = (i_double / (i_double - uno)) * dif_cuadrada_duracion;
                return primer_factor * (primer_termino_corchete + segundo_termino_corchete);
            }
            
                 
        }
        private void armarIntervalosDeFrecuencias(List<Fila> lstFilas)
        {
            var lstOrdenada = lstFilas.OrderBy(x=> x.nodo3).Select(y=> y.nodo3).ToList();
            for (int i = 0; i < lstOrdenada.Count(); i++)
            {
                Intervalo objIntervalo = new Intervalo();
                if (i == 0)
                {
                    objIntervalo.limiteInferior = 0;

                }
                else
                {
                    objIntervalo.limiteInferior = lstOrdenada[i - 1];

                }
                objIntervalo.limiteSuperior = lstOrdenada[i];
                if (i == lstOrdenada.Count() - 1)
                    objIntervalo.limiteSuperior = 99999;
                lstIntervalos.Add(objIntervalo);

            }
                
            
        }
        private void calcularFrecuenciasObservadas(double nodotres)
        {
            foreach (var intervalo in lstIntervalos)
            {
                if (nodotres > intervalo.limiteInferior && nodotres <= intervalo.limiteSuperior)
                    intervalo.frecuenciaObservada += 1;
            }
        }
        private void calcularPorcentajes()
        {
            int cantidad = Convert.ToInt32(txtCantSim.Text);
            foreach (var intervalo in lstIntervalos)
            {
                intervalo.porcentaje = ((double)intervalo.frecuenciaObservada * Convert.ToDouble(100)) / ((double)cantidad - Convert.ToDouble(14));
                porcentaje_anterior += intervalo.porcentaje;
                intervalo.porcentaje_acumulado += porcentaje_anterior;

            }
        }
        private void cargarGrilla()
        {
            grdPlantilla.DataSource = lstMostrar;
        }
        private void cargarDatosLabels()
        {
            int cantidad = Convert.ToInt32(txtCantSim.Text);
            lblDuracionPromedio.Text = ultima_duracion_promedio.ToString("n2");
            lblMax.Text = maximo.ToString("n2");
            lblMin.Text = minimo.ToString("n2");
            lblProbabilidad.Text = probabilidad.ToString("n2");
            lblFechaNC.Text = ultima_fecha_nc90.ToString("n2");
            lblFechaNCIntervalos.Text = lstIntervalos.Where(x => x.porcentaje_acumulado >= Convert.ToDouble(90)).Select(y => y.limiteInferior).FirstOrDefault().ToString("n2");
            lblAct1Critica.Text = ((act1Critica) / cantidad).ToString("n2");
            lblAct2Critica.Text = ((act2Critica) / cantidad).ToString("n2");
            lblAct3Critica.Text = ((act3Critica) / cantidad).ToString("n2");
            lblAct4Critica.Text = ((act4Critica) / cantidad).ToString("n2");
            lblAct5Critica.Text = ((act5Critica) / cantidad).ToString("n2");
            lblttAct1.Text = tiempoTardioAct1.ToString("n2");
            lblttAct2.Text = tiempoTardioAct2.ToString("n2");
            lblttAct3.Text = tiempoTardioAct3.ToString("n2");
            lblttAct4.Text = tiempoTardioAct4.ToString("n2");
            lblttAct5.Text = tiempoTardioAct5.ToString("n2");
        }
    }
}
