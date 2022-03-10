using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_78293
{
    class VectorEstado
    {
        public int numEvento { get; set; }
        public string TipoEvento { get; set; }
        public double Reloj { get; set; }
        public int NumCliente { get; set; }

        public double RndDemandaCliente { get; set; }
        public int DemandaCliente { get; set; }
        public int Venta { get; set; }
        public int Stock{ get; set; }
        public bool Reap { get; set; }
        public int CantReap{ get; set; }
        public int ClienteSeRetira { get; set; }
        public int ColaClientes { get; set; }
        public Cliente LlegadaCliente { get; set; }
        public Servidor SEmpleado1 { get; set; }
        public Servidor SEmpleado2 { get; set; }
        public Servidor SHorno { get; set; }
       
    }
}
