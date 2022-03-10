using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_78293
{
    class EulerSolver
    {
        double P, h, T, dT, t;
        double[][] lines = new double[5000][];
       
        List<TablaEuler> lstTablaE = new List<TablaEuler>();
        double fin_coccion;

        public EulerSolver(double P, double h,double T)
        {
            this.t = 0;
            
            this.P = P;
            this.T = T;
            this.h = h;
            this.dT = (-0.5 * this.T) + (900 / this.P);
            //T'= -0,5*T+(900/P)

           

            double[] line = { this.t, this.T, this.dT};
            this.lines[0] = line;
            TablaEuler objFila = new TablaEuler();
            objFila.tn = Math.Round(line[0], 2);
            objFila.T = Math.Round(line[1], 2);
            objFila.dT = Math.Round(line[2], 2);
            
            lstTablaE.Add(objFila);
        }

        private void nextState()
        {
            // Avanza la resolución de la ED una línea. haciendo primero avanzar el tiempo.
            this.t = this.t + this.h;
            this.T = this.T + (this.h * this.dT);
            this.dT = ((double)-0.5 * this.T) + ((double)900 / this.P);

        }
        private double[] generateLine()
        {
            double[] line = new double[4]; // Este arreglo contiene una línea de la resolución.
            TablaEuler objFila = new TablaEuler();

            line[0] = this.t;
            line[1] = this.T;
            line[2] = this.dT;
            
            objFila.tn = Math.Round(this.t, 4);
            objFila.T = Math.Round(this.T, 4);
            objFila.dT = Math.Round(this.dT, 4);
           
            lstTablaE.Add(objFila);
            return line;
        }
        public double[][] resolverED()
        {
            for (int i = 1; i < lines.Length; i++)
            {
                this.nextState();
                this.lines[i] = this.generateLine();
            }
            return this.lines;
        }

        //HACER FUNCION PARA ENCONTRAR EL VALOR QUE PERMANEZCA 15 MIN

        public double FindTime(int fin_coccion)
        {
            int n = this.lines.Length;
            double cant = 0;
            for (int i = 1; i < n ; i++)
            {
                if(this.lines[i][1] == this.lines[i+1][1])
                {
                    cant += 1;
                    if (cant == fin_coccion)
                    {
                        
                        return lines[i][0];
                        
                    }
                }
            }
            return 0;

        }

       
        public List<TablaEuler> getTablaEuler()
        {
            return lstTablaE;

        }
    }
}
