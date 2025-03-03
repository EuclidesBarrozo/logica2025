//Ler uma palavra que será adivinhada
Console.WriteLine("Digite a palavra a ser adivinhada:");
String palavra = Console.ReadLine();
//Criar um vetor de Char do tamanho da palavra
Char[] palavra2 = new char[palavra.Length];
//inserir o símbolo _ no 2o vetor
for (int i = 0; i < palavra2.Length; i++)
{
    palavra2[i] = '_';
}
//criar a variável tentativas com o valor 5
int tentativas = 5;
//criar uma estrutura de repetição que repetirá
//enquanto a pessoa não acertar ou  as tentativas
//não acabarem
for( ;palavra != new String(palavra2) && tentativas > 0;)
{
    Console.WriteLine(palavra2);
    Console.WriteLine(tentativas);
    //ler um letra
    Console.WriteLine("Digite uma letra");
    String letra = Console.ReadLine();
    //verificar se a palavra contém a letra
    //se sim, preencher o 2o vetor
    bool achou = false; 
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra[0] == palavra[i])
        {
            palavra2[i] = letra[0];
            achou = true;
        }
    }
    //se não, diminuir o número de tentativas
    if (achou == false)
    {
        tentativas--;
    }
}
if(tentativas > 0)
{
    Console.WriteLine("Parabéns!");
}
else
{
    Console.WriteLine("Você perdeu.");
}

//Depois da estrutura verificar se a pessoa ganhou
