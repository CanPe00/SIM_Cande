using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_78293
{
    class VectorEstadoMostrar
    {
        public int numEvento { get; set; }
        public string TipoEvento { get; set; }
        public string Reloj { get; set; }
        public int NumCliente { get; set; }

        public double RndDemandaCliente { get; set; }
        public int DemandaCliente { get; set; }
        public int Venta { get; set; }
        public int Stock { get; set; }
        public string Reap { get; set; }
        public int CantReap { get; set; }
        public string CantPromClienteSeRetira { get; set; }
        public int ColaClientes { get; set; }
        public double RndCliente { get; set; }
        public double TiempoEntreLlegadasCliente{ get; set; }
        public double ProximaLlegadaCliente { get; set; }
        public string EstadoSE1 { get; set; }
        public string Cliente_Num_SE1 { get; set; }
        public double RndSE1 { get; set; }
        public double TiempoDeAtencionSE1{ get; set; }
        public double ProximoFinAtencionSE1 { get; set; }
        public string OrdenSE1 { get; set; }
        public string EstadoSE2 { get; set; }
        public string Cliente_Num_SE2 { get; set; }
        public double RndSE2 { get; set; }
        public double TiempoDeAtencionSE2 { get; set; }
        public double ProximoFinAtencionSE2 { get; set; }
        public string OrdenSE2 { get; set; }
        public string EstadoSHorno{ get; set; }
       
        public double TiempoDeAtencionSHorno { get; set; }
        public double ProximoFinAtencionSHorno { get; set; }
        
    }
}
