Console.WriteLine("Digite o 1o número:");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a razão:");
int razao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de números:");
int qtd = Convert.ToInt32(Console.ReadLine());

/*for(int i = 0; i < qtd; i++)
{
    int pa = n1 + i * razao;
    Console.Write(pa + " ");
}*/

for(int i = 0; i < qtd; i++)
{
    Console.Write(n1 + " ");
    n1 = n1 + razao;
}