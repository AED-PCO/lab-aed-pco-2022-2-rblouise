//QUESTÃO 1
namespace labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int igual = 0, diferente = 0;
            string ArqLinha, DigitaTxt;

            StreamReader sr = new StreamReader("C:\\Users\\ribei\\Documents\\Aed");
            ArqLinha = sr.ReadLine();
            Console.WriteLine("Digite um texto:");
            DigitaTxt = Console.ReadLine();

            sr.Close();

            foreach (char line in ArqLinha)
            {
                if (DigitaTxt == ArqLinha)
                {
                    igual++;
                }
                diferente++;
            }
            Console.WriteLine("IGUAIS {0}", igual);
            Console.WriteLine("DIFERENTES {0}", diferente);
        }
    }
}

//QUESTÃO 3
namespace labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Linha;

            StreamReader sr = new StreamReader("C:\\Users\\ribei\\Documents\\Aed\\Entrada.txt");
            Linha = sr.ReadLine();



            StreamWriter sw = new StreamWriter("C:\\Users\\ribei\\Documents\\Aed\\Saída.txt");
            sw.WriteLine(Inversão(Linha));

            sr.Close();
            sw.Close();
        }

        static string Inversão (string linha)
        {
            char [] palavra = linha.ToCharArray();
            string resultado = string.Empty;
            for (int i = palavra.Length - 1; i >= 0; i--)
            {

                resultado += palavra[i];
            }

            return resultado;
        }
    }
}

//QUESTÃO 4
namespace labcf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] cpf = new long[10];

            for (int i = 0; i < cpf.Length; i++)
            {
                cpf[i] = GerarCPF();
            }

            MergeSort(cpf, 0, cpf.Length - 1);

            for (int i = 0; i < cpf.Length; i++)
            {
                Console.WriteLine("CPF:{0}", cpf[i]);
            }
        }
        static long GerarCPF()
        {
            Random RandNumero = new Random();
            string digito = RandNumero.Next(9).ToString();
            int soma = 0, i,j;

            for(i = 1, j = 10; i<9; i++, j--){
                digito += RandNumero.Next(9).ToString();
                soma += int.Parse(digito[i].ToString()) * j;
                
            }
            digito += DigitoVerifica(soma);

            soma = 0;

            for(i = 1, j = 10; i<10; i++, j--){
                soma += int.Parse(digito[i].ToString()) * j;
            }

            soma = DigitoVerifica(soma);
            digito += soma;


            long cpf = long.Parse(digito);
            return cpf;
        }

        static int DigitoVerifica(int soma)
        {
            if((soma % 11) == 0 || (soma % 11) == 1){
                return 0;
            }else{
                return 11 - (soma % 11);
            }
        }

        static void MergeSort(long[] vet, int inicio, int fim)
        {
            if(inicio < fim){
                int meio = inicio + (fim - inicio) / 2;
                MergeSort(vet, inicio, meio);
                MergeSort(vet, meio + 1, fim);
                Intercala(vet, inicio, fim);
            }
        }

        static void Intercala(long[] vet, int inicio, int fim)
        {
            int meio = (inicio + fim) / 2;
            int k = inicio, i,j;

            long[] vetAux1 = new long[meio + 1];
            long[] vetAux2 = new long[fim - meio];

            for (i = 0; i < (meio - inicio) + 1; i++) 
                vetAux1[i] = vet[inicio + i];
            for (j = 0; j < fim - meio; j++) 
                vetAux2[j] = vet[meio + 1 + j];

            for (i = 0, j = 0;i < (meio - inicio) + 1 && j < fim - meio; k++){
                if (vetAux1[i] <= vetAux2[j]){
                    vet[k] = vetAux1[i];
                    i++;
                }else{
                    vet[k] = vetAux2[j];
                    j++;
                }
            }
            for (;i < (meio - inicio) + 1; i++, k++) 
                vet[k] = vetAux1[i];
            for (;j < fim - meio; j++, k++) 
                vet[k] = vetAux2[j];
        }
    }
}

//QUESTÃO 5
namespace lab
{
    internal class Program
    {
        static void Main()
        {
            int [] vetor = new int[7] { 10, 5, 7, 15, 22, 9, 30 };
            Console.WriteLine($"O número retornado pela função é: {funcao(6, vetor)}");
        }
        static int funcao(int a, int[] v)
        {
            if (a == 1)
                return v[0];
            else
            {
                int x;
                x = funcao(a - 1, v);
                if (x > v[a - 1])
                    return x;
                else
                    return v[a - 1];
            }
        }
    }
}
