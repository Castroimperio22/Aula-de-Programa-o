/* 5.Escreva um programa que lê o tamanho do lado de um quadrado e imprime um quadrado 
 * daquele tamanho com asteriscos. Seu programa deve usar laços de repetição e 
 * funcionar para quadrados com lados de todos os tamanhos entre 1 e 20.
Por exemplo, para lado igual a 5:
*/

decimal lado, area = 0;

Console.WriteLine(" Digie o Tamanho do Lado: ");
lado = Convert.ToDecimal(Console.ReadLine());

if(lado >= 1 || lado == 20)
{
    for(int i = 0; i <= lado; i++)
    {
        area = lado * lado;
        Console.WriteLine(area + ", ") ;
    }
}

else
{
    Console.WriteLine(" Número Inválido: ");
}

Console.WriteLine(" O Resultado do Seu quadrado foi de: " + area);