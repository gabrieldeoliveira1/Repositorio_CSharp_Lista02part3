using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Pilares_4_Enumeracao
{
    internal class Classe_TipoVeiculo
    {
        public int Numero;
        public string Info;
        public string Status1;


        public enum TIPO
        {
            Carro = 1,
            Moto = 2,
            Caminhao = 3
        }

        public TIPO Tipo(int Numero)
        {
            TIPO tp = TIPO.Carro;
            switch (Numero)
            {
                case 1:
                    tp = TIPO.Carro; break;
                case 2:
                    tp = TIPO.Moto; break;
                case 3:
                    tp = TIPO.Caminhao; break;

            }

            Info = tp.ToString();
            return tp;
        }
    }
}
