/*
Enunciado 10: Precisão de Ponto Flutuante
Com base na seção "Armadilhas e Erros Comuns", escreva um código que demonstre 
o erro de precisão ao somar 0.1 + 0.2 e comparar com 0.3 usando o tipo double. 
Exiba o resultado da comparação no console.
*/

double num = 0.1 + 0.2;

Console.WriteLine($"O valor da soma de 0.1 + 0.2 é: {num}" );

Console.WriteLine($"A comparação 'a == 0.3' resulta em: {(num == 0.3)}");
Console.WriteLine("Isso ocorre devido à forma como números de ponto flutuante são representados na memória.");