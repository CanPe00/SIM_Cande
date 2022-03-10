using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_SIM
{
    public class VectorEstado
    {
        public int numEvento { get; set; }
        public string TipoEvento { get; set; }
        public double Reloj { get; set; }
        public int Pedido { get; set; }
        public Pedido LlegadaPedido { get; set; }
        public Servidor Servidor1 { get; set; }
        public Servidor Servidor2 { get; set; }
        public Servidor Servidor3 { get; set; }
        public Servidor Servidor4 { get; set; }
        public Servidor Servidor5 { get; set; }
        public Ensamble Ensamble { get; set;  }
    }
}
