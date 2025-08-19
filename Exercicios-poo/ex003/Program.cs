/* 
Enunciado 3: Informações de Produto
Declare variáveis para armazenar as informações de um produto em um estoque: 
o nome do produto (string), a quantidade de itens (int), o preço unitário (double) 
e se o produto está ativo para venda (bool). Atribua valores e exiba-os no console usando concatenação. 
*/

string nomeProduto = "Celular";
int quantidadeItens = 10;
double precoUnitario = 2000.00;
bool ativoParaVenda = true;

Console.WriteLine("Nome do Produto: " + nomeProduto);
Console.WriteLine("Quantidade no estoque: " + quantidadeItens);
Console.WriteLine("Preço Unitário: " + precoUnitario);
Console.WriteLine("Ativo para Venda: " + ativoParaVenda);