LAB7 - PROVA

1- Modele, projete e calcule a complexidade de um programa que:

a) Leia as linhas de um arquivo chamado "arq1.txt".

b) Peça para o usuário inserir um texto no terminal/console.

c) Compare o texto escrito pelo usuário e o texto lido no arquivo, e escreva na tela quantos termos "IGUAIS" e "DIFERENTES".

d) Descreva quais as operações relevantes.

    Operações Relevantes: Atribuição.
    Complexidade: O(n2)
    Modelagem: Foi feita uma função para ler as linhas do arquivo e usuario digitar o texto em seguida o codigo mostra quais letras sao iguais e diferentes.
    
Imagem:

![image](https://user-images.githubusercontent.com/101759423/198360347-7c7d246f-ebc3-494b-aae2-33ffc7f69e7e.png)

Gráfico:

![image](https://user-images.githubusercontent.com/101759423/198360891-ffd3c73f-d5c4-4882-8754-df8d636bf166.png)

2a) Quantos e quais casos base/condições de parada para a função funcRec1()?
 
    Há condição de parada so se o A for menor ou igual a 1.

b) Explique com suas palavras o que a função funcRec1() calcula.

    A função calcula a Recursividade do If que se menor ou igual a 1 retorna 0, se não ela retorna a função.

c) Represente a pilha de execução para a chamada funcRec1(6).

   ![image](https://user-images.githubusercontent.com/101759423/197077406-87105e9a-38c1-4837-b517-831e94ba78fc.png)

3- Modele, projete e calcule a complexidade de um programa que:

a) Leia a primeira linha de um arquivo chamado "entrada.txt".

b) Escreva em um arquivo chamado "saida.txt" o conteúdo lido no arquivo de entrada ao contrário.

c) Descreva quais as operações relevantes.
      
    Operações Relavantes: Atribuição e Comparação.
    Complexidade: O(n2)
    Modelagem: O código trata-se de uma leitura de dois arquivos: entrada.txt e saida.txt, quando feita a leitura e feito um vetor que percorre o for e em seguida faz um returno no Resultado.
    
Imagem:

![image](https://user-images.githubusercontent.com/101759423/198352680-bf81dde8-256a-4dba-bd8b-09dc470e9cd8.png)
![image](https://user-images.githubusercontent.com/101759423/198352700-6b048758-2b34-4763-8ea5-e0a05d4312c1.png)

Gráfico:

![image](https://user-images.githubusercontent.com/101759423/198362978-77af6abb-310c-450a-bc64-e2e5dd4f3ada.png)

4- Um banco famoso enfrenta problemas de consulta em seu banco de registros. Dentre os problemas identificados pela gerência está a localização das contas dos seus titulares nas listagens e nos relatórios impressos em diferentes situações. Um especialista de TI sugeriu ordenar as contas por meio do CPF dos seus titulares antes das impessões. Dentre alguns algoritmos pré-selecionados para essa ordenação, o especialista escolheu o algoritmo de ordenação por Inserção. Se você fosse o especialista, responda:

a) O especialista escolheu um bom algoritmo? Justique

    Não. Pois a ordenação por Inserção geraria um custo alto tratando-se de ordernar CPF.
  
b) Qual algoritmo de ordenação usaria?

    Merge Sort. Porque primeiro ele divide o vetor para depois ordenar e sua complexidade log elevado a n.

c) Descreva quais operações relevantes.

    Atribuição.
  
d) Demonstre a viabilidade da sua solução para 10 registros.

    O código foi feito 4 funções, uma para gerar CPF's aleatoriamente, outra que faz um if e soma, outra para fazer o Merge Sort percorrer pelo vetor e por fim a função intercala que percorre o for no vetor e compara os CPF's no inicio, meio e fim.

Imagem: 

![image](https://user-images.githubusercontent.com/101759423/198369471-40cb2483-f3b2-400b-a93c-dcd05031e6a3.png)

Gráfico:

![image](https://user-images.githubusercontent.com/101759423/198369666-3a7ba1f6-d06f-4e2a-b2dc-583d6aa0cab2.png)


5- O código a seguir implementa uma função recursiva. Analise-o e indique o que será retornado pela função, caso os parâmetros possuam os seguintes dados: V = {10, 5, 7, 15, 22, 9, 30} e A = 6.

    static int funcao(int a, int[] v){
            if(a == 1)
                return v[0];
            else{
                int x;
                x = funcao(a - 1, v);
                if(x > v[a - 1])
                    return x;
                else
                    return v[a - 1];
            }
        }
         
   
    Descrição: Será retornado pela Função o 22.
    
Imagem:

![image](https://user-images.githubusercontent.com/101759423/198371390-af417f84-8a9f-486f-a851-828fa02acb82.png)

Gráfico:

![image](https://user-images.githubusercontent.com/101759423/198371636-c0ffc36d-1adc-40c5-b213-84987261d59c.png)
