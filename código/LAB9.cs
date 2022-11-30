// PILHA ESTATICA INVERTIDA

namespace lab9_pilhainvertida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0, valor = 0, QuantVetor = 6;
            int[] vetor = new int[QuantVetor];
            int[] VetorInversoVa = new int[QuantVetor];


            for (int x = 0; x < QuantVetor; x++)
            {
                Console.WriteLine("Digite um número para inserir no Vetor:");
                valor = int.Parse(Console.ReadLine());

                if (pos < QuantVetor)
                {
                    Pilha(vetor, pos, valor);
                    pos += 1;
                }
                else
                {
                    Console.WriteLine("Sem espaço, remova os números para incluir.");
                }
            }

            Console.Write("Pilha Original: ");
            VetorAmostra(vetor);

            VetorInversoVa = PilhaInvertida(vetor, QuantVetor);

            Console.Write("Pilha Inversa: ");
            VetorAmostra(VetorInversoVa);
        }
        static void VetorAmostra(int[] Vet)
        {
            for (int x = 0; x < Vet.Length; x++)
            {
                Console.Write($"{Vet[x]} ");
            }
        }

        static int[] Pilha(int[] vetor, int ValAux, int valor)
        {
            vetor[ValAux] = valor;
            return vetor;
        }
        static int[] PilhaInvertida(int[] vetor, int QuantVetor)
        {
            int[] VetorInverso = new int[QuantVetor];

            for (int y = 0; y < QuantVetor; y++)
            {
                for (int z = QuantVetor - 1; z >= 0; z--)
                {
                    VetorInverso[z] = vetor[y];
                    y++;
                }
            }
            return VetorInverso;
        }
        
    }
}
