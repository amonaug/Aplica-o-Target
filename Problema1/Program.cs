using System;

namespace Problema_1
{
    class Progam
    {
        static void Main()
        {
            int num;
            bool fibonacci;

            Console.Write("Digite o número a ser testado: ");
            num = int.Parse(Console.ReadLine());
            fibonacci = Teste(num);

            if(fibonacci == true)
                Console.WriteLine("O número {0} faz parte da sequência de fibonacci", num);
            else
                Console.WriteLine("{0} não pertence a sequência de fibonacci", num);
        }

        static bool Teste(int numP)
        {
            double caso_1, caso_2;

            //Expressão para calcular se o número faz parte da sequência de fibonacci
            caso_1 = (5*Math.Pow(numP, 2)) + 4;
            caso_2 = (5*Math.Pow(numP, 2)) - 4;

            //Descobrindo se a raiz é exata
            if(Math.Sqrt(caso_1) == (int)Math.Sqrt(caso_1) || Math.Sqrt(caso_2) == (int)Math.Sqrt(caso_2))
                return true;
            else
                return false;
        }
    }
}
