using System;

namespace CombustiPlus
{
    public class Despacho
    {
        public int Numero { get; set; }
        public string Placa { get; set; } = "";
        public string Combustible { get; set; } = "";
        public decimal Galones { get; set; }
        public string Pago { get; set; } = "";
        public decimal Total { get; set; }

        public override string ToString()
        {
            return FormattableString.Invariant(
                $"#{Numero:00} {Placa}  {Combustible,-8} {Galones,5:0.0} gal  {Pago,-8}  RD$ {Total,9:N2}");
        }
    }
}