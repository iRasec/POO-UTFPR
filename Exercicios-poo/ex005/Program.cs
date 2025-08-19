/* 
Enunciado 5: Formas de Exibição
Declare duas variáveis do tipo string, uma para o primeiro nome e outra para 
o sobrenome de uma pessoa. Exiba o nome completo no console de duas maneiras diferentes:

Usando o operador de concatenação (+).
Usando a interpolação de strings ($"{}").
*/

string nome = "Luan";
string sobrenome = "Costa";

Console.WriteLine(nome +" "+ sobrenome);
Console.WriteLine($"{nome} {sobrenome}");