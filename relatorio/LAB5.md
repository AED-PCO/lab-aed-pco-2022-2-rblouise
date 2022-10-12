LABORATORIO 5 - COMPLEXIDADE

![image](https://user-images.githubusercontent.com/101759423/195226264-4ffad6bd-92d5-4b8a-82f0-625eee4232b3.png)

1 – Operação mais relevante?

    Atribuição e Multiplicação.
   
2 – Marcar operações

    for(int i=n; i>1; i--){
        res = res*i;
        
3 – Avaliar sequências e laços.

    f(n) = n - 1

4 – Há variação de casos?

    Não.

![image](https://user-images.githubusercontent.com/101759423/195226833-4b14ad28-f927-4c5e-9952-5213d3d15a81.png)

1 – Operação mais relevante?

    Comparação.

2 – Marcar operações.

    if(arr[i] == x) return x;
    
3 – Avaliar sequências e laços.

    f(n) = n

4 – Há variação de casos?
  
    Sim,
    Pior Caso: O(n)
    Melhor Caso: O(1)
    Caso Médio: n + 1 / 2 = n
    

![image](https://user-images.githubusercontent.com/101759423/195226903-06697871-4df2-424d-a96b-d708d218e7ff.png)

1 – Operação mais relevante?

    Comparação, Atribuição e Divisão.

2 – Marcar operações.

    for(int pos = 0; pos<arr1.length; pos++){
    for(int j = 0; j<arr1.length; j++){
        if(j!=pos)
    res[pos] += arr1[pos]/arr1[j];

3 – Avaliar sequências e laços.

    Multiplicação e Divisão: f(n) = n2 - n
    Comparação: (n) = n2
    
4 – Há variação de casos?

    Não.

![image](https://user-images.githubusercontent.com/101759423/195226954-220973b4-5d1e-43bd-b823-e3f71978ce36.png)

1 – Operação mais relevante?

    Atribuição, Soma e Divisão

2 – Marcar operações.

    for(int i=0; i<dados.length; i++){
         double soma=0.0;
         for(int j=0; j<=i; j++)
          soma += dados[j];
          vet[i] = soma/(i+1);
          }
          
3 – Avaliar sequências e laços.

    Divisão: f(n) = n
    Atribuição: f(n) = n2 + n / 2
    Soma: f(n) = n2 + n / 2 + n

4 – Há variação de casos?

    Não
