using System;
using System.Collections;
using System.Collections.Generic;

namespace TP6_SIM
{
    class RungeKuttaSolver
    {
        double a, b, c, h, x1, x2, t, k1, k2, k3, k4, l1, l2, l3 , l4;
        double[][] lines = new double[200][];
        private readonly Random _random = new Random(); // Random number generator.
        List<TablaRK> lstTablaRK = new List<TablaRK>();

        public RungeKuttaSolver(double b, double c, double h, double x1, double x2)
        {
            // El constructor setea los valores iniciales para la ecuacion diferencial.
            this.h = h;
            this.t = 0;

            // Cacular un numero aleatorio para a.
            this.a = (double)0.5 + (_random.NextDouble() * ((double)2.0 - (double)0.5));
            this.b = b;
            this.c = c;

            this.x1 = x1;
            this.x2 = x2;
            
            this.l1 = this.h * (Math.Exp(-this.c * this.t) - (this.a * this.x2) - (this.b * this.x1));
            this.l2 = this.h * (Math.Exp(-this.c * (this.t + (0.5 * this.h))) - (this.a * (this.x2 + (0.5 * this.l1))) - (this.b * (this.x1 + (0.5 * this.k1))));
            this.l3 = this.h * (Math.Exp(-this.c * (this.t + (0.5 * this.h))) - (this.a * (this.x2 + (0.5 * this.l2))) - (this.b * (this.x1 + (0.5 * this.k2))));
            this.l4 = this.h * (Math.Exp(-this.c * (this.t + this.h)) - (this.a * (this.x2 + this.l3)) - (this.b * (this.x1 + this.k3)));

            this.k1 = this.h * this.x2;
            this.k2 = this.h * (this.x2 + ((double)0.5 * this.l1));
            this.k3 = this.h * (this.x2 + ((double)0.5 * this.l2));
            this.k4 = this.h * (this.x2 + this.l3);
            
            double[] line = {t, x1, k1, k2, k3, k4, x2, l1, l2, l3, l4};
            this.lines[0] = line;
            TablaRK objFilaRK = new TablaRK();
            objFilaRK.t = Math.Round(line[0], 3);
            objFilaRK.x1 = Math.Round(line[1], 3);
            objFilaRK.k1 = Math.Round(line[2], 3);
            objFilaRK.k2 = Math.Round(line[3], 3);
            objFilaRK.k3 = Math.Round(line[4], 3);
            objFilaRK.k4 = Math.Round(line[5], 3);
            objFilaRK.x2 = Math.Round(line[6], 3);
            objFilaRK.l1 = Math.Round(line[7], 3);
            objFilaRK.l2 = Math.Round(line[8], 3);
            objFilaRK.l3 = Math.Round(line[9], 3);
            objFilaRK.l4 = Math.Round(line[10], 3);
            lstTablaRK.Add(objFilaRK);


        }

        private void nextState()
        {   
            // Avanza la resolución de la ED una línea. haciendo primero avanzar el tiempo.
            this.t = this.t + this.h;

            this.l1 = this.h * (Math.Exp(-this.c * this.t) - (this.a * this.x2) - (this.b * this.x1));
            this.l2 = this.h * (Math.Exp(-this.c * (this.t + (0.5 * this.h))) - (this.a * (this.x2 + (0.5 * this.l1))) - (this.b * (this.x1 + (0.5 * this.k1))));
            this.l3 = this.h * (Math.Exp(-this.c * (this.t + (0.5 * this.h))) - (this.a * (this.x2 + (0.5 * this.l2))) - (this.b * (this.x1 + (0.5 * this.k2))));
            this.l4 = this.h * (Math.Exp(-this.c * (this.t + this.h)) - (this.a * (this.x2 + this.l3)) - (this.b * (this.x1 + this.k3)));

            this.k1 = this.h * this.x2;
            this.k2 = this.h * (this.x2 + (0.5 * this.l1));
            this.k3 = this.h * (this.x2 + (0.5 * this.l2));
            this.k4 = this.h * (this.x2 + this.l3);

            this.x1 = this.x1 + ((this.k1 + (2 * this.k2) + (2 * this.k3) + this.k4) / 6);
            this.x2 = this.x2 + ((this.l1 + (2 * this.l2) + (2 * this.l3) + this.l4) / 6);
        }
        private double[] generateLine() 
        {
            double[] line = new double[11]; // Este arreglo contiene una línea de la resolución.
            TablaRK objFilaRK = new TablaRK();

            line[0] = this.t;
            line[1] = this.x1;
            line[2] = this.k1;
            line[3] = this.k2; 
            line[4] = this.k3; 
            line[5] = this.k4;
            line[6] = this.x2;
            line[7] = this.l1; 
            line[8] = this.l2; 
            line[9] = this.l3;
            line[10] = this.l4;
            objFilaRK.t = Math.Round(this.t, 3);
            objFilaRK.x1 = Math.Round(this.x1, 3);
            objFilaRK.k1 = Math.Round(this.k1, 3);
            objFilaRK.k2 = Math.Round(this.k2, 3);
            objFilaRK.k3 = Math.Round(this.k3, 3);
            objFilaRK.k4 = Math.Round(this.k4, 3);
            objFilaRK.x2 = Math.Round(this.x2, 3);
            objFilaRK.l1 = Math.Round(this.l1, 3);
            objFilaRK.l2 = Math.Round(this.l2, 3);
            objFilaRK.l3 = Math.Round(this.l3, 3);
            objFilaRK.l4 = Math.Round(this.l4, 3);
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

        public double findSecondLocalMaxima()
        {
            ArrayList mx = new ArrayList();
            int n = this.lines.Length;

            // Checking if the first point is local maxima.
            if (this.lines[0][1] > this.lines[1][1])
                mx.Add(0);

            // Iterating over all points to check local maxima
            for (int i = 1; i < n - 1; i++)
            {    
                // Condition for local maxima
                if ((this.lines[i - 1][1] < this.lines[i][1]) && (this.lines[i][1] > this.lines[i + 1][1]))
                    mx.Add(i);
            }
            // Checking whether the last point is local maxima.
            if (this.lines[n - 1][1] > this.lines[n - 2][1])
                mx.Add(n - 1);

            int secondMaxIndex = (int) mx[1];
            return this.lines[secondMaxIndex][0];
        }
        public List<TablaRK> getTablaRK()
        {
            return lstTablaRK;
        }
    }
}
