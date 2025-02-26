/*// João comprou 500 limões 
Console.WriteLine("Quantos limões João comprou?");
double qtdLimoes = Convert.ToDouble(Console.ReadLine());
//(custo por unidade R$ 0,50)
Console.WriteLine("Qual o custo por unidade?");
double precoLimoes = Convert.ToDouble(Console.ReadLine());
// e vendeu 300
Console.WriteLine("Quantos limões João vendeu?");
double qtdLimoesVendidos = Convert.ToDouble(Console.ReadLine());
// (R$ 1,00 cada) 
Console.WriteLine("Qual o preço por unidade?");
double precoLimoesVendidos = Convert.ToDouble(Console.ReadLine());
//qual o custo da compra,
double custo = qtdLimoes * precoLimoes;
Console.WriteLine("Custo: " + custo);
//qual o faturamento da venda
double faturamento = qtdLimoesVendidos * precoLimoesVendidos;
Console.WriteLine("Faturamento: " + faturamento);
//qual o lucro/prejuízo
double lucro = faturamento - custo;
Console.WriteLine("Lucro: " + lucro);*/

//Calcular o total de pontos de um time.
//Solicitar a quantidade de vitórias, empates e derrotas.
//pontuação de um time (vitória - 3, empate - 1, derrota - 0)
Console.WriteLine("Quantidade de vitórias:");
int vitorias = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Quantidade de empates:");
int empates = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Quantidade de derrotas:");
int derrotas = Convert.ToInt32(Console.ReadLine());

int pontos = vitorias * 3 + empates * 1;
Console.WriteLine("Total de ponto: " + pontos);




