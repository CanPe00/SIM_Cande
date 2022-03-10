using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_SIM
{
    public class VectorEstadoMostrar
    {
        public int Evento { get; set; }
        public string TipoEvento { get; set; }
        public string Reloj { get; set; }
        public int Pedido { get; set; }
        public double RndPedido { get; set; }
        public double TiempoEntreLlegadasPedido { get; set; }
        public double ProximaLlegadaPedido { get; set; }
        public string EstadoS1 { get; set; }
        public string Materiales_NumPedidoS1 { get; set; }
        public double RndS1 { get; set; }
        public double TiempoDeAtencionS1 { get; set; }
        public double ProximoFinAtencionS1 { get; set; }
        public int ColaS1 { get; set; }
        public double InicioAtencionS1 { get; set; }
        public string EstadoS2 { get; set; }
        public string Materiales_NumPedidoS2 { get; set; }
        public double RndS2 { get; set; }
        public double TiempoDeAtencionS2 { get; set; }
        public double ProximoFinAtencionS2 { get; set; }
        public int ColaS2 { get; set; }
        public double InicioAtencionS2 { get; set; }
        public string EstadoS3 { get; set; }
        public string Materiales_NumPedidoS3 { get; set; }
        public double RndS3 { get; set; }
        public double TiempoDeAtencionS3 { get; set; }
        public double ProximoFinAtencionS3 { get; set; }
        public int ColaS3 { get; set; }
        public double InicioAtencionS3 { get; set; }
        public string EstadoS4 { get; set; }
        public string Materiales_NumPedidoS4 { get; set; }
        public double RndS4 { get; set; }
        public double TiempoDeAtencionS4 { get; set; }
        public double ProximoFinAtencionS4 { get; set; }
        public int ColaS4 { get; set; }
        public double InicioAtencionS4 { get; set; }
        public string EstadoS5 { get; set; }
        public string Materiales_NumPedidoS5 { get; set; }
        public double RndS5 { get; set; }
        public double TiempoDeAtencionS5 { get; set; }
        public double ProximoFinAtencionS5 { get; set; }
        public int ColaS5_S2 { get; set; }
        public int ColaS5_S4 { get; set; }
        public double InicioAtencionS5 { get; set; }
        public int Ensamble_Deposito_S3 { get; set; }
        public int Ensamble_Deposito_S5 { get; set; }
        public int CantidadEnsamblesTotal { get; set; }
        public int CantidadEnsamblesXHr { get; set; }
        public double CantidadEnsamblesPromedioXhr { get; set; }
        public int CantMaxColaS1 { get; set; }
        public int CantMaxColaS2 { get; set; }
        public int CantMaxColaS3 { get; set; }
        public int CantMaxColaS4 { get; set; }
        public int CantMaxColaS5_S2 { get; set; }
        public int CantMaxColaS5_S4 { get; set; }

        public int CantMaxEnsamble_Deposito_S5 { get; set; }
        public int CantMaxEnsamble_Deposito_S3 { get; set; }
        public double CantidadProductosSistema { get; set; }
    }
}
