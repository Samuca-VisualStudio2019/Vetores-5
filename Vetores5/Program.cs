using System;
using System.Diagnostics;
using System.Globalization;

namespace Vetores5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] valores = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(valores[i]);
            }

            double somaDosPares = 0.0;
            int quantidadeDEPares = 0;
            for(int i = 0; i < N; i++)
            {
                if(vet[i] % 2 == 0)
                {
                    somaDosPares = somaDosPares + vet[i];
                    quantidadeDEPares++;
                }
            }

            if(quantidadeDEPares == 0)
            {
                Console.WriteLine("Não havia número par");
            }
            else
            {
                double media = somaDosPares / quantidadeDEPares;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
