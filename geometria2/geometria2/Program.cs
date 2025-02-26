// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Senac");
//declaração de variável
//Tipo nome_da_variável = valor
//String nome = "Ana";
//Console.WriteLine("Bem-vinda " + nome);
//Console.WriteLine("Digite o nome do seu curso");
//String curso = Console.ReadLine();
Console.WriteLine("Curso:" + curso);*/

Console.WriteLine("Digite a largura do terreno:");
double largura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o comprimento do terreno:");
//Console.ReadLine - Ler o valor digitado pelo usuário
//Convert.ToDouble - Converte um valor para o tipo double
double comprimento = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Largura: " + largura);
Console.WriteLine("Comprimento: " + comprimento);
double area = comprimento * largura;
Console.WriteLine("Área: " + area);
//calcule o perímetro
double perimetro = 2 * comprimento + 2 * largura;
Console.WriteLine("Perímetro: " +  perimetro);
//calcular o preço do terreno
//considere que cada m² vale R$100
double preco = area * 100;
Console.WriteLine("Preço: " + preco);