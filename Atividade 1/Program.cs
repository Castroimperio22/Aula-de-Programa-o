
/* 1. Faça um programa que leia três números, verifique (usando if e else)
   e mostre o maior e o menor deles;  (Não utilize estrutura de repetição)
*/

decimal numero1, numero2, numero3, maiornumero = 0, menornumero = 0;


Console.WriteLine("Digite o Primeiro Número: ");
numero1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o Segundo Número: ");
numero2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o Terceiro Número: ");
numero3 = Convert.ToDecimal(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3)
{

    maiornumero = numero1;

}
else
{
    if (numero2 > numero3)
    {
        maiornumero = numero2;
    }
    else
    {
        maiornumero = numero3;
    }
}

if (numero1 < numero2 && numero1 < numero3)
{

    menornumero = numero1;

}
else
{
    if (numero2 < numero3)
    {
        menornumero = numero2;
    }
    else
    {
        menornumero = numero3;
    }
}

Console.WriteLine("\n O Maior Número é: " + maiornumero);
Console.WriteLine("\n O Menor Número é: " + menornumero);
