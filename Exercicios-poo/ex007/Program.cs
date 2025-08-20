/*
Enunciado 7: Operação de Ponto Flutuante
Declare uma variável do tipo double para armazenar o preço de um 
produto e uma variável do tipo int para a quantidade comprada. 
Calcule o valor total (preco * quantidade) e armazene o resultado 
em uma variável double. Exiba o valor total.
*/

double precoProduto;
int quantidadeComprada;
double totalCompra;

Console.Write("Digite o preço do produto: ");
precoProduto = double.Parse(Console.ReadLine());

Console.Write("Digite a quantidade comprada: ");
quantidadeComprada = int.Parse(Console.ReadLine());

totalCompra = precoProduto * quantidadeComprada;

Console.WriteLine($"Valor total da compra: R$ {totalCompra:F2}");