using System;

namespace Teste_do_Léo
{
    class Program
    {
        static void Main(string[] args)
        {
            int minhavariavel1 = new Random().Next(1,20);
            int minhavariavel2 = 6;
            int minhavariavel3 = minhavariavel1 * minhavariavel2;
            int minhavariavel4 = minhavariavel3 / minhavariavel1;
            string Certo = "Certo!";
            //bool conversao = int.TryParse(Certo, out minhavariavel1);
            //minhavariavel1 = int.Parse(Certo);
            //Console.WriteLine(conversao);
            //Console.WriteLine(minhavariavel1);

            int fatorial = 0;

            for (int i = minhavariavel1; i >= 0; i = i - 1)
            {
                Console.WriteLine(i);
                fatorial = fatorial + i;

            }

            Console.WriteLine(" fatorial {0}! = {1}", minhavariavel1, fatorial);

            int SOMA = 0;
            int[] dados = new int[] { 12, 13, 14 };
            for(int i = 0; i< dados.Length; i++)
            {
                string sinal;
                if (i == dados.Length - 1)
                {
                    sinal = "";
                }
                else
                {
                    sinal = "+";
                }
                Console.Write("{0} {1} ", dados[i], sinal);
                SOMA = SOMA + dados[i];
            }
            Console.WriteLine("= {0}", SOMA);
            
            bool mv1_maior_mv2 = (minhavariavel1 > minhavariavel2 && minhavariavel1 < minhavariavel3);
  
            //Console.WriteLine("sua variável 1 é {0} e sua variável 2 é {1}. O resultado de sua multiplicação é {2}, já o resultado de sua divisão é {3}", minhavariavel1, minhavariavel2, minhavariavel3, minhavariavel4);
            int x = minhavariavel2;
            Console.WriteLine("Se x + {0} = 11, então qual o valor de x?", minhavariavel1);
            string y = Console.ReadLine();
            int valordigitado;
            bool z = int.TryParse( y, out valordigitado);
            z = z && valordigitado == minhavariavel2;
            if (!z)
            {
                do
                {
                    Console.WriteLine("Incorreto");
                     y = Console.ReadLine();
                     z = int.TryParse(y, out valordigitado);
                    

                } while (!z || valordigitado != minhavariavel2);
            }
            Console.WriteLine("Correto");

            Console.ReadLine();
         


            
        }
    }
}