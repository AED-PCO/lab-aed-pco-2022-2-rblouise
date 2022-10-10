//Escreva um método recursivo que retorne o fatorial de um número.

 namespace lab2_fatorial
{
    internal class Program
    {
        static int fatorial(int n)
        {
            if (n == 0)
               return 1;

            else
                return n * fatorial(n - 1);
        }
        static void Main(string[] args)
        {
            int x, Resultado;
            Console.WriteLine("Digite um número para retorno de fatorial");
            x = int.Parse(Console.ReadLine());
            Resultado = fatorial(x);
            Console.WriteLine($"{Resultado}");
            Console.ReadKey();
        }
    }
}

//Uma multiplicação pode ser vista como uma sequência de somas. Escreva um método recursivo que realize a multiplicação de dois números inteiros, A e B, recebidos por parâmetro.

 namespace lab_2_Multiplicação
{
    internal class Program
    {
        static int multi(int a, int b)
        {
            if (a == 1)
                return b;
            if (a > 0)
                return multi(b, a - 1) + b;
                return multi(b, a + 1) + b;
        }
        static void Main(string[] args)
        {
            int a, b, resultado;

            Console.WriteLine("Digite um número para realizar a multiplicação");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número para realizar a multiplicação");
            b = int.Parse(Console.ReadLine());

            resultado = multi(a, b);

            Console.WriteLine($"O resultado é {resultado}");
        }
    }
}

//Escreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado de AB.

namespace Lab_2_Potencia
{
    internal class Program
    { 
        static int potencia (int a, int b){
            if (b == 0)
                return 1;
            else
                return (a * potencia (a, b - 1));
        }
        static void Main(string[] args)
        {
            int a, b, resultado;

            Console.WriteLine("Digite o número da base para realizar a Potencia");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número do expoente para realizar a Potencia");
            b = int.Parse(Console.ReadLine());
            resultado = potencia(a, b);
            Console.WriteLine($"O resultado é {resultado}");
            Console.ReadKey();
        }
    }
}

//Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase.

namespace lab2_fra
{
    internal class Program
    {
       static int frase(string palavra, char letra)
        {
            if (palavra == "")
                return (0);
            else if (palavra[0] == letra)
                return frase(palavra.Substring(1), letra) + 1;
            else
                return frase(palavra.Substring(1), letra);
        }
        static void Main(string[] args)
        {


            string palavra;
            char letra;
            Console.WriteLine("Digite a frase:");
            palavra = Console.ReadLine();

            Console.WriteLine("Digite a letra:");
            letra = char.Parse(Console.ReadLine());

            int n = frase(palavra, letra);
            Console.WriteLine($"Frase {palavra} possui {n} quantidades de letras {letra}");
        }
    }
}

// Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.
namespace lab2_vet_
using System;

  class Program {
    static int soma (int [] vetor, int tamanho)
            {
    
                if (tamanho == 0)
                    return 0;
    
                else 
                    return vetor[tamanho - 1] + soma(vetor, tamanho - 1);
            }
            static void Main(string[] args)
            {   
                int x,N, resultado=0;
                
                int[] vetor = new int[10];
    
                for (x = 0; x < 10; x++)
                {
                    Console.Write("Qual valor para preencher o vetor: ");
                    N = int.Parse(Console.ReadLine());

                  if(N%2==0){
                    resultado=resultado+N;
                  }
    
                    vetor[x] = N;
                }
              
                Console.WriteLine($"a soma é:{resultado}");
                Console.ReadKey();
          }
    }
}



//Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal.

 namespace lab2_exer6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string frase;

            Console.WriteLine("Digite uma frase:");
            frase = Console.ReadLine();
            Console.WriteLine("Frase escrita sem vogal: ");
            Console.WriteLine(TiraVolume(frase.ToCharArray()));
        }

        static char[] volume = { 'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U',
            'á', 'é', 'í', 'ó', 'ú',
            'ã', 'õ', 'Ã', 'Õ', 'â', 
            'ê', 'î', 'ô', 'û', ' ', 'Ê', 'Î', 'Ô', 'Û' };

        static string TiraVolume(char[] texto, int auxiliar = -1, string output = "")
        {
            auxiliar ++;
            if (auxiliar == texto.Length)
            {
                return output;
            }
            if (!volume.ToList().Contains(texto[auxiliar]))
            {
                output += texto[auxiliar];
            }
            return TiraVolume(texto, auxiliar, output);
        }
    }
}







//Fibonacci
namespace ConsoleApp7
{
    internal class Program
    {
        static int fib(int x)
        {
            if (x == 1)
                return 1;

            if (x == 2)
                return 1;

            return fib(x - 1) + fib(x - 2);
             
        }
            static void Main(string[] args)
        {
            int y, Resultado;
            Console.WriteLine("Digite um número para a sequencia de Fibonacci");
            y = int.Parse(Console.ReadLine());
            Resultado = fib(y);
            Console.WriteLine($"{Resultado}");
            Console.ReadKey();
        }


    }
}
