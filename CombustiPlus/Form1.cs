namespace CombustiPlus
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private bool ValidarDatos()
        {
            if (txtPlaca.Text.Trim().Length != 7)
            {
                MessageBox.Show("La placa debe tener 7 caracteres", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlaca.Focus();
                return false;
            }

            if (nudGalones.Value <= 0)
            {
                MessageBox.Show("Los galones deben ser más de 0", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudGalones.Focus();
                return false;
            }

            return true;
        }
        private decimal CalcularTotal()
        {
            string combustible = cmbCombustible.Text;
            decimal galones = nudGalones.Value;

            decimal precio = combustible switch
            {
                "Premium" => 290m,
                "Regular" => 272m,
                "Gasoil" => 225m,
                _ => 0m
            };

            lstDetalle.Items.Clear();

            decimal total = Math.Round(galones * precio, 2);
            lstDetalle.Items.Add(FormattableString.Invariant(
                $"{galones:0.0} gal × RD$ {precio:N2} = RD$ {total:N2}"));

            if (galones >= 20)
            {
                total = Math.Round(total * 0.98m, 2);
                lstDetalle.Items.Add(FormattableString.Invariant(
                    $"Descuento 20+ galones -2 %: RD$ {total:N2}"));
            }

            if (cmbPago.Text == "Tarjeta")
            {
                total = Math.Round(total * 1.03m, 2);
                lstDetalle.Items.Add(FormattableString.Invariant(
                    $"Tarjeta +3 %: RD$ {total:N2}"));
            }

            lstDetalle.Items.Add(FormattableString.Invariant($"TOTAL: RD$ {total:N2}"));
            return total;
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;
            CalcularTotal();
        }
        private readonly List<Despacho> despachos = new List<Despacho>();

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            decimal total = CalcularTotal();

            Despacho d = new Despacho
            {
                Numero = despachos.Count + 1,
                Placa = txtPlaca.Text.Trim().ToUpper(),
                Combustible = cmbCombustible.Text,
                Galones = nudGalones.Value,
                Pago = cmbPago.Text,
                Total = total
            };

            despachos.Add(d);
            lstDespacho.Items.Add(d);
            ActualizarResumen();
        }

        private void ActualizarResumen()
        {
            decimal vendido = 0m;
            decimal galones = 0m;
            Despacho mayor = null;

            foreach (Despacho d in despachos)
            {
                vendido += d.Total;
                galones += d.Galones;
                if (mayor == null || d.Total > mayor.Total)
                    mayor = d;
            }

            lblResumen.Text = FormattableString.Invariant(
                $"{despachos.Count} despachos · Vendido RD$ {vendido:N2} · Galones {galones:0.0} · Mayor: #{mayor.Numero:00} {mayor.Placa} (RD$ {mayor.Total:N2})");
        }
    }
}
