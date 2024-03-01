using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula6_Pilares_4_Enumeracao
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void _003_Load(object sender, EventArgs e)
        {
            Classe_TipoVeiculo ct = new Classe_TipoVeiculo();
            MessageBox.Show("Tipo do veículo escolhido: " + ct.Tipo(1));
        }
    }
}
