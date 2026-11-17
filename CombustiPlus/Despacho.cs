using System;

namespace CombustiPlus
{
    public class Despacho
    {
        public int Numero { get; set; }
        public string Placa { get; set; }
        public string Combustible { get; set; }
        public double Galones { get; set; }
        public string Pago { get; set; }
        public double Total { get; set; }

        public Despacho(int numero, string placa, string combustible, double galones, string pago, double total)
        {
            Numero = numero;
            Placa = placa;
            Combustible = combustible;
            Galones = galones;
            Pago = pago;
            Total = total;
        }

        public override string ToString()
        {
            return $"Despacho #{Numero} | Placa: {Placa} | Combustible: {Combustible} | Galones: {Galones:N2} | Pago: {Pago} | Total: RD$ {Total:N2}";
        }
    }
}