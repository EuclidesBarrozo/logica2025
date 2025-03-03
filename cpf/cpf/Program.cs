//Crie uma string que receberá apenas os números de um cpf.

String cpf;
do
{
    Console.WriteLine("Digite os números do seu CPF:");
    cpf = Console.ReadLine();
} while (cpf.Length != 11);

//Crie uma segunda string
Char[] cpf2 = new Char[14];
//utilizando um estrutura de repetição passe os números de uma
//string para a outra
for(int i = 0, j = 0; i < cpf.Length; i++, j++)
{
    if(i == 3 || i == 6)
    {
        cpf2[j] = '.';
        j++;
    }
    if(i == 9)
    {
        cpf2[j] = '-';
        j++;
    }
    cpf2[j] = Convert.ToChar(cpf[i]);

}

Console.WriteLine(cpf2);
//escreva a segunda string
