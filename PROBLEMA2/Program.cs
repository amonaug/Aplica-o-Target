using System;

namespace Problema_2
{
    class Progam
    {
        static void Main()
        {
            string texto = "A aranha arranha a jarra e a jarra arranha a aranha, nem a aranha arranha a jarra nem a jarra arranha a aranha";

            int cont;
            cont = LetraA(texto);

            if(cont == 0)
                Console.WriteLine("Não existe nenhuma letra 'a' no texto");
            else
                Console.WriteLine("Existem {0} letras 'a' no texto", cont);
        }

        static int LetraA(string textoP)
        {
            int cont = 0;
            textoP = textoP.ToLower();

            for(int i = 0; i < textoP.Length; i++)
            {
                if(textoP[i] == 'a')
                    cont++;
            }

            return cont;
        }
    }
}
