namespace Aula6_Pilares_4_Enumeracao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Classe_TamCamis tc = new Classe_TamCamis();
            MessageBox.Show("Tamanho camiseta: " + tc.ObterTamanho(5));
        }
    }
}
