//Declarar uma variável string e inserir uma palavra
Console.WriteLine("Digite uma palavra:");
String nome = Console.ReadLine();

//Digitar uma letra
Console.WriteLine("Digite uma letra:");
String letra = Console.ReadLine();

int cont = 0;
//Criar uma estrutura de repetição para percorrer o vetor de string
for (int i = 0; i < nome.Length; i++)
{
    //escrever letra por letra da palavra separado por espaço
    //Console.Write(nome[i] + " ");
    if (letra[0] == nome[i])
    {
        //Console.WriteLine("Letra encontrada");
        cont++;
    }
}
Console.WriteLine("A letra " + letra + " foi encontrada "
    + cont + " vezes.");


//verificar se a palavra possui essa letra 

