using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_SIM
{
    public class Servidor
    {
        public string Estado { get; set; }
        public int Materiales_NumPedido { get; set; }
        public double Rnd { get; set; }
        public double TiempoAtencion { get; set; }
        public double ProximoFinAtencion { get; set; }
        public int Cola { get; set; }
        public double InicioAtencion { get; set; }
        public bool TerminoS1 { get; set; }
        public bool TerminoS4 { get; set; }
        public bool TerminoS2 { get; set; }
        public int Cola_Ser5_S2 { get; set; }
        public int Cola_Ser5_S4 { get; set; }
        public double HoraLlegadaCola { get; set; }
        public double HoraSalidaCola { get; set; }
        public double HoraLlegadaCola_S5_S2 { get; set; }
        public double HoraSalidaCola_S5_S2 { get; set; }
        public double HoraLlegadaCola_S5_S4 { get; set; }
        public double HoraSalidaCola_S5_S4 { get; set; }

    }
}
