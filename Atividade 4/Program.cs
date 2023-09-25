/* 4. Faça um programa que leia um valor n, inteiro e positivo, calcule e mostre a seguinte 
 * soma: S = 1 + 1/2 + 1/3 + 1/4 + … + 1/n.*/

int n = 0, soma = 0;

Console.WriteLine(" Digite o Primero Valor d N: ");
n = Convert.ToInt32(Console.ReadLine());

for ( int i = 0; i <= n; i++ )
{

    soma =  1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / n;

}

Console.WriteLine(" O Seu Resultado é: " + soma ); 