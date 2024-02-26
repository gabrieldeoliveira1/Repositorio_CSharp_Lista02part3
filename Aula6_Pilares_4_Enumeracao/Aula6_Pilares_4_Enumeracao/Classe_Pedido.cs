using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Pilares_4_Enumeracao
{
    internal class Classe_Pedido
    {
        public int Numero;
        public string Info;


        public enum Status
        {
            Novo = 1,
            Processando = 2,
            Enviado = 3,
            Entregue = 4
        }

        public Status ObterTamanho(int Numero)
        {
            Status stat = Status.Novo;

            if (Numero > (int)Status.Enviado) 
            {
                stat = Status.Entregue;
            }
            if (Numero > (int)Status.Novo && Numero < (int)Status.Enviado)
            {
                stat = Status.Processando;
            }
            if (Numero > (int)Status.Processando && Numero < (int)Status.Entregue)
            {
                stat = Status.Enviado;
            }
            else
                stat = Status.Novo;
        

            Info = stat.ToString();
            return stat;
        }
    }
}