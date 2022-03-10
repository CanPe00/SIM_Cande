using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace TP6_SIM
{
    public class EulerSolver
    {
        double a, b, c, h, x, dx, t, dx2;
        double[][] lines = new double[200][];
        private readonly Random _random = new Random(); // Random number generator.
        List<TablaEuler> lstTablaE = new List<TablaEuler>();

        public EulerSolver(double b, double c, double h, double x, double dx)
        {
            this.t = 0;
            this.a = (double)0.5 + (_random.NextDouble() * ((double)2.0 - (double)0.5)); // Cacular un numero aleatorio para a.
            this.b = b;
            this.c = c;
            this.h = h;
            this.x = x;
            this.dx = dx;
            this.dx2 = Math.Exp(-this.c * this.t) - (this.a * this.dx) - (this.b * this.x);
            
            double[] line = {this.t, this.x, this.dx, this.dx2};
            this.lines[0] = line;
            TablaEuler objFila = new TablaEuler();
            objFila.tn = Math.Round(line[0], 2);
            objFila.x = Math.Round(line[1], 2);
            objFila.dx = Math.Round(line[2], 2);
            objFila.dx2 = Math.Round(line[3], 2);
            lstTablaE.Add(objFila);
        }

        private void nextState()
        {   
            // Avanza la resolución de la ED una línea. haciendo primero avanzar el tiempo.
            this.t = this.t + this.h;
            this.x = this.x + (this.h * this.dx);
            this.dx = this.dx + (this.h * this.dx2);
            this.dx2 = Math.Exp(-this.c * this.t) - (this.a * this.dx) - (this.b * this.x);
        }
        private double[] generateLine() 
        {
            double[] line = new double[4]; // Este arreglo contiene una línea de la resolución.
            TablaEuler objFila = new TablaEuler();

            line[0] = this.t;
            line[1] = this.x;
            line[2] = this.dx;
            line[3] = this.dx2; // Esta es la ecuación diferencial.
            objFila.tn = Math.Round(this.t, 2);
            objFila.x = Math.Round(this.x, 2);
            objFila.dx = Math.Round(this.dx, 2);
            objFila.dx2 = Math.Round(this.dx2, 2);
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
        public List<TablaEuler> getTablaEuler()
        {
            return lstTablaE;

        }

    }
}
