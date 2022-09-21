Exercícios Introdução

1- namespace LAB1_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1000; n <= 9999; n++)
                Console.WriteLine(n);
        }
        void verifica(int n)
        {
            int parte1 = n / 100;
            int parte2 = n % 100;
            int sm = parte1 + parte2;
            int prod = sm * sm;

            if (prod == n)
            {
                Console.WriteLine("%d\n", n);
                Console.WriteLine("-------------------------\n");
                Console.WriteLine("%2d + %2d = %d * %d = %d.\n\n", parte1, parte2, sm, sm, prod);
            }
        }

    }
}

2- namespace lab1_exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, cont = 0;

            Console.WriteLine("Digite um número:");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {

                if (x % i == 0)
                {
                    cont++;
                }

            }

            if (cont == 2)
            {
                Console.WriteLine($"{x} é um número primo");
            }
            else
            {
                Console.WriteLine($"{x} não é um número primo");
            }

            int num, u, soma1 = 0;

            for (num = 1; num <= 1000; num++)
            {

                for (u = 1; u < num; u++)
                {

                    if (num % u == 0)
                    {
                        soma1 = soma1 + u;
                    }
                }
                if (num == soma1)
                {
                    Console.WriteLine($"{x} é um número perfeito");
                }

                soma1 = 0;
            }
        }
    }
}

3-----------

4- namespace lab1_exerci4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 3];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Digite os valores da Matriz {i + 1}{j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int SomaLinha(int[,] matriz, int linha, int NmrDeColunas)
            {
                int result = 0;
                for (int i = 0; i < NmrDeColunas; i++)
                {
                    result += matriz[linha, i];
                }

                return result;
            }

            int SomaColuna(int[,] matriz, int NmrDeLinhas, int coluna)
            {
                int resultado = 0;
                for (int i = 0; i < NmrDeLinhas; i++)
                {
                    resultado += matriz[coluna, i];
                }

                return resultado;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Resultado da Soma da Linha {i + 1}: {SomaLinha(matriz, i, 3)}");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Resultado da Soma da Coluna {i + 1}: {SomaColuna(matriz, 5, i)}");
            }
        }
    }
}

5- namespace lab1_exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, fat = 1;
                Console.WriteLine("Digite um número maior que zero:");
                x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {

                fat = fat * i;

            }

            Console.WriteLine($"O fatorial é {fat}");
        }

    }
}

6-  public static double Potencia(int y, int x)
        {
            double Resultado;
            return Resultado = Math.Pow(x, y);
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro X");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite um número inteiro Y");
            int y = int.Parse(Console.ReadLine());
            
            double Z;
            Z = Potencia(y, x);
            Console.WriteLine($"O resultado da potência é {Z}");
            Console.ReadKey();
        }
    }
}
