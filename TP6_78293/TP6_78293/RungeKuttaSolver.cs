using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_78293
{
    class RungeKuttaSolver
    {
        double P, h, T, t, k1, k2, k3, k4;
        double[][] lines = new double[5000][];
  
        List<TablaRK> lstTablaRK = new List<TablaRK>();

        public RungeKuttaSolver(double P, double h, double T)
        {
            // El constructor setea los valores iniciales para la ecuacion diferencial.
          

            t = 0;

            this.P = P;
            this.T = T;
            this.h = h;
            //(-0, 5 * this.T) + (900 / this.P);


           

            this.k1 = this.h * ((double)-0.5 * this.T) + ((double)900 / this.P);
            this.k2 = this.h * ((double)-0.5 * (this.T + ((double)0.5 * this.k1))) + ((double)900 / this.P);
            this.k3 = this.h * ((double)-0.5 * (this.T + ((double)0.5 * this.k2))) + ((double)900 / this.P);
            this.k4 = this.h * ((double)-0.5 * (this.T + this.k2)) + ((double)900 / this.P);

            double[] line = { t, T, k1, k2, k3, k4};
            this.lines[0] = line;
            TablaRK objFilaRK = new TablaRK();
            objFilaRK.tn = Math.Round(line[0], 3);
            objFilaRK.T = Math.Round(line[1], 3);
            objFilaRK.k1 = Math.Round(line[2], 3);
            objFilaRK.k2 = Math.Round(line[3], 3);
            objFilaRK.k3 = Math.Round(line[4], 3);
            objFilaRK.k4 = Math.Round(line[5], 3);
            
            lstTablaRK.Add(objFilaRK);


        }

        private void nextState()
        {
            // Avanza la resolución de la ED una línea. haciendo primero avanzar el tiempo.
            this.t = this.t + this.h;

            this.k1 = this.h * ((double)-0.5 * this.T) + ((double)900 / this.P);
            this.k2 = this.h * ((double)-0.5 * (this.T + ((double)0.5 * this.k1))) + ((double)900 / this.P);
            this.k3 = this.h * ((double)-0.5 * (this.T + ((double)0.5 * this.k2))) + ((double)900 / this.P);
            this.k4 = this.h * ((double)-0.5 * (this.T + this.k2)) + ((double)900 / this.P);

            this.T = this.T + ((this.k1 + (2 * this.k2) + (2 * this.k3) + this.k4) / 6);
            
        }
        private double[] generateLine()
        {
            double[] line = new double[11]; // Este arreglo contiene una línea de la resolución.
            TablaRK objFilaRK = new TablaRK();

            line[0] = this.t;
            line[1] = this.T;
            line[2] = this.k1;
            line[3] = this.k2;
            line[4] = this.k3;
            line[5] = this.k4;
            
            objFilaRK.tn = Math.Round(this.t, 3);
            objFilaRK.T = Math.Round(this.T, 3);
            objFilaRK.k1 = Math.Round(this.k1, 3);
            objFilaRK.k2 = Math.Round(this.k2, 3);
            objFilaRK.k3 = Math.Round(this.k3, 3);
            objFilaRK.k4 = Math.Round(this.k4, 3);
            
            lstTablaRK.Add(objFilaRK);
            return line;
        }
        public double[][] resolverED()
        {
            for (int i = 1; i < lines.Length; i++)
            {
                this.nextState();
                this.lines[i] = this.generateLine();
            }
            return lines;
        }

        public double FindTime(int fin_coccion)
        {
            int n = this.lines.Length;
            int cant = 0;
            for (int i = 1; i < n; i++)
            {
                if (this.lines[i][1] == this.lines[i + 1][1])

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

        public List<TablaRK> getTablaRK()
        {
            return lstTablaRK;
        }
    }
}
