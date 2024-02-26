using System;

namespace Aula6_Pilares_4_Enumeracao
{
    public class Classe_TamCamis
    {
        public int Numero;
        public string Tamanho;


        public enum TamanhoCamisetas
        {
            Inextistente = 0,
            Pequeno = 10,
            Medio = 20,
            Grande = 30
        }

        public TamanhoCamisetas ObterTamanho(int Numero)
        {
            TamanhoCamisetas tam = TamanhoCamisetas.Pequeno;


            if (Numero < (int)TamanhoCamisetas.Pequeno || Numero > (int)TamanhoCamisetas.Grande) 
            {
                tam = TamanhoCamisetas.Inextistente;
            }
            else
            {
                if (Numero > (int)TamanhoCamisetas.Medio)
                {
                    tam = TamanhoCamisetas.Grande;
                }
                else if (Numero > (int)TamanhoCamisetas.Pequeno)
                {
                    tam = TamanhoCamisetas.Medio;
                }
                else
                    tam = TamanhoCamisetas.Pequeno;

                Tamanho = tam.ToString();
                
            }
                return tam;
        }
            

            


    }
}