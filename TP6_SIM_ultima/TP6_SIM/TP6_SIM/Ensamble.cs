using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_SIM
{
    public class Ensamble
    {
        public bool TerminoS5 { get; set; }
        public bool TerminoS3 { get; set; }
        public int Deposito_S3 { get; set; }
        public int Deposito_S5 { get; set; }
        public int CantEnsambles { get; set; }
        public double HoraLlegadaCola_Deposito_S3 { get; set; }
        public double HoraSalidaCola_Deposito_S3 { get; set; }
        public double HoraLlegadaCola_Deposito_S5 { get; set; }
        public double HoraSalidaCola_Deposito_S5 { get; set; }
        public double TiempoEnsamble { get; set; }
        public double ProximoFinEnsamble { get; set; }
        public string Estado { get; set; }
    }
    
}
