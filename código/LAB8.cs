// FILA
namespace lab8_fila
{
    internal class Program
    {
        static int [] InserirFila(int[] Vetor, int pos, int valor)
        {
            Vetor[pos] = valor;
            return Vetor;
        }

        static int [] TirarFila(int[] Vetor)
        {
            int aux =  Vetor[0];
            for(int i = 1; i<Vetor.Length; i++)
            {
                Vetor[i - 1] = Vetor[i];
            }
            Console.WriteLine("O elemento retirado foi: " + aux);

            return Vetor;

        }
        static void Main(string[] args)
        {
            int Pos = 0, valor = 0, tam = 10;
            int [] Vetor = new int[tam];
            
            for(int j=0; j<tam;j++)
            {
                valor = j * j;
                if (Pos < tam)
                {
                    InserirFila(Vetor, Pos, valor);
                    Pos += 1;
                }
                else
                    Console.WriteLine("vetor não tem espaço livre! \n Retire elementos antes de tentar inserir");
            }

            TirarFila(Vetor);
            Pos -= 1;

            Console.WriteLine("A posição de referência é: " + Pos);

            if (Pos > 0)
            {
                Console.WriteLine("Os valores na Fila são: ");
                int aux_retira = Pos;
                for (int k = 0; k < aux_retira; k++)
                {
                    TirarFila(Vetor);
                    Pos -= 1;
                }
            }
            else
                Console.WriteLine("A fila esta vazia");
            
        }
    }
}

