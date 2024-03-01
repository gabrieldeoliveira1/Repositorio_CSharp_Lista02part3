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
        public string Status1;


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
            switch (Numero)
            {
                case 1:
                    stat = Status.Novo; break;
                case 2:
                    stat = Status.Processando; break;
                case 3: 
                    stat = Status.Enviado; break;
                    case 4: 
                    stat = Status.Entregue; break;
                
            }

            Info = stat.ToString();
            return stat;
        }

        public string Atualiz_Pedido()
        {
             Status1 = "";
            return Status1;
        }
    }
}



