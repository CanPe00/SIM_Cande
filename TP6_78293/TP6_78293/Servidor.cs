using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_78293
{
    class Servidor
    {
        public string Estado { get; set; }
        public int Cliente_Num { get; set; }
        public double Rnd { get; set; }
        public double TiempoAtencion { get; set; }
        public double ProximoFinAtencion { get; set; }
        public double InicioAtencion { get; set; }

        public List<string> Orden { get; set; }
    }
}
