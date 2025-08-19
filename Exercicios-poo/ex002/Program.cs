/* 
Enunciado 2: Mensagem de Boas-Vindas Interativa
Crie um programa que solicite ao usuário que digite seu nome. 
O programa deve ler o nome digitado e, em seguida, exibir uma mensagem de boas-vindas 
personalizada usando o nome fornecido. Utilize a interpolação de strings para formar a mensagem final.
*/

Console.Write("Digite seu nome: ");
string nomeUsuario = Console.ReadLine();
Console.Write($"Seja bem-vindo(a), {nomeUsuario} !");
