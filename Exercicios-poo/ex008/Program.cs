/*
Enunciado 8: Variáveis Lógicas (Booleanas)
Declare uma variável int para a idade de um usuário. Em seguida, declare uma 
variável bool chamada maiorDeIdade e atribua a ela o resultado de uma comparação 
(idade >= 18). Por fim, exiba o valor da variável maiorDeIdade.
*/

int idade;
bool maiorDeIdade;
Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());
if (idade >= 18)

    maiorDeIdade = true;

else
    maiorDeIdade = false;

Console.WriteLine($"A afirmação 'O usuário é maior de idade' é: {maiorDeIdade}");