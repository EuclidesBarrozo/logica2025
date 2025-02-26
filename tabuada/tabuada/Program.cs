// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Calcular a tabuada do:");
int numero = Convert.ToInt32(Console.ReadLine());

for (int cont = 1; cont <= 10; cont++)
{
    Console.WriteLine(numero + " x " + cont + " = " + numero * cont);
}*/

//Crie um sistema que leia 5 números, armazene em um
//vetor e escreva esses números.
int[] numeros = new int[5];
for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Escreva o " + (i+1) + "o número:");
    numeros[i] = Convert.ToInt32(Console.ReadLine());   
}
//Escreva os valores contidos no vetor
for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Números salvos: " + numeros[i]);
}
