string palavra = Console.ReadLine();

for(int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite uma letra:");
    string letra = Console.ReadLine();
    for(int j = 0; j < palavra.Length; j++)
    {
        if (palavra[j] == letra[0])
        {
            Console.WriteLine("Letra encontrada");
        }
    }
}

