﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void _002_Load(object sender, EventArgs e)
        {
            Classe_Pedido cp = new Classe_Pedido();
            cp.Status1 = "";

            if (!string.IsNullOrEmpty(cp.Status1))
            {
                MessageBox.Show("O Status novo do pedido é: " + cp.Status1);
            }
            else
            {
                MessageBox.Show("Info do pedido: " + cp.ObterTamanho(4));
            }
        }
    }
}
