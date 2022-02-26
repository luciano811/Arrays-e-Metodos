using System;
using System.Linq;

namespace ProgramacaoEstruturada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[]
            {
                -8, -33, 45, 6, 3, 4, 1, 13, 17, 3, 5, 2, 4, 6, 8, -1,
            };

            int maior = EncontraroMaior(numeros);
            Console.WriteLine($" O maior valor é: {maior}");

            int menor = EncontraroMenor(numeros);
            Console.WriteLine($" O menor valor é: {menor}");

            double media = EncontrarMedia(numeros);
            Console.WriteLine($" O valor da média é: {media}");

            int[] trimaiores = Encontrar3maiores(numeros);
            Console.WriteLine("Os três maiores números são: " + string.Join("; ", trimaiores));

            int negativos = EncontrarNegativos(numeros);
            Console.WriteLine($"Quantidade de negativos é: {negativos} " );

            Array.Sort(numeros);
            Console.WriteLine($"Os números da sequência são:" + string.Join("; ", numeros));

            Console.WriteLine("Digite o número que quer remover da lista: ");
            int numeroParaRemover = Convert.ToInt32(Console.ReadLine());
            RemoverNumeros(ref numeros, numeroParaRemover);

            Console.Write("O novo array é: ");

            ExibirNovoArray(ref numeros);

            Console.WriteLine();
            Console.ReadKey();

            
            


        }

        static int EncontraroMaior(int[] numeros)
        {
            int maior = 0;
            
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                    maior = numeros[i];
            }

            return maior;
        }

        static int EncontraroMenor(int[] numeros)
        {
            int menor = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                    menor = numeros[i];
            }

            return menor;
        }

        static double EncontrarMedia(int[] numeros)
        {
            double media = 0;
            double soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
                media = soma / 10;
                continue;

            };

            return media;
        }
        static int [] Encontrar3maiores(int[] numeros)
        {
            Array.Sort(numeros);
            Array.Reverse(numeros);
            
            int[] trimaiores = new int[3];

            for (int i = 0; i < trimaiores.Length; i++)
            {
                trimaiores[i] = numeros[i];
            }

            return trimaiores;
        }

        static int EncontrarNegativos(int[] numeros)
        {
            
            int qtdnegativos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    qtdnegativos++;
                    continue;
                }
            }

            return qtdnegativos;
        }

        //Debuguei todo esse método RemoverNumeros pra entender o funcionamento dele.
        static void RemoverNumeros(ref int[] numeros, int numeroParaRemover) //6
        {
            int qtdParaRemover = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroParaRemover)
                    qtdParaRemover++;
            }

            //array novo com os números diferentes do número removido...
            int[] novosnumeros = new int[numeros.Length - qtdParaRemover];
            int j = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != numeroParaRemover)
                {
                    novosnumeros[j] = numeros[i];
                    j++;
                }
            }

            numeros = novosnumeros;
        }

        static void ExibirNovoArray(ref int[] numeros)
        {

            for (int l = 0; l < numeros.Length; l++)
            {
                Console.Write($"{numeros[l]}, ");
            }
        }

}
    }
    
