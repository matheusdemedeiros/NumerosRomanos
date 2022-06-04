using System;
using System.Windows.Forms;

namespace NumerosRomanos.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private readonly Conversor conversor;
        
        public TelaPrincipalForm()
        {
            InitializeComponent();
            this.txtRomano.TextAlign = HorizontalAlignment.Center;
            this.txtArabico.TextAlign = HorizontalAlignment.Center;
            this.conversor = new Conversor();
        }

        private void btnConverterParaArabico_Click(object sender, EventArgs e)
        {
            txtArabico.Clear();

            var resultado = conversor.ConverterRomanoParaArabico(this.txtRomano.Text);

            if (resultado == int.MinValue)
                txtArabico.Text = "VALOR INVÁLIDO";
            else
                txtArabico.Text = Convert.ToString(resultado);
        }

        private void btnConverterParaRomano_Click(object sender, EventArgs e)
        {
            txtRomano.Clear();

            int.TryParse(txtArabico.Text, out int valor);

            if (valor >= 0)
            {
                var resultado = conversor.ConverterArabicoParaRomano(valor);

                txtRomano.Text = resultado;
            }
        }

        private void TelaPrincipalForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 1;
            timer.Enabled = true;
            timer.Tick += new EventHandler(Ticks);
        }

        private void TelaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Enabled = false;
        }

        private void Ticks(object sender, EventArgs e)
        {
            MostrarHoraEmRomano();

            MostrarHoraEmArabico();
        }

        private void MostrarHoraEmArabico()
        {
            var agora = DateTime.Now;
            labelHoraArabico.Text = Convert.ToString(agora.Hour);
            labelMinutoArabico.Text = Convert.ToString(agora.Minute);
            labelSegundoArabico.Text = Convert.ToString(agora.Second);

        }

        private void MostrarHoraEmRomano()
        {
            var agora = DateTime.Now;
            labelHoraRomana.Text = conversor.ConverterArabicoParaRomano(agora.Hour);
            labelMinutoRomano.Text = conversor.ConverterArabicoParaRomano(agora.Minute);
            labelSegundoRomano.Text = conversor.ConverterArabicoParaRomano(agora.Second);
        }
    }
}
