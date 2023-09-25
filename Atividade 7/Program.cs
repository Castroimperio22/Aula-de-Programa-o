// 7. Faça um programa para calcular n! (Fatorial de n), sendo que o valor inteiro de n é
// fornecido pelo usuário.Sabe-se que: 

int num, fatorial, cont;
num = 0;
fatorial = 1;

Console.WriteLine("Digite o Numero: ");
num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    Console.WriteLine(" Entrada Inválido Aqui So Número Positivos ");
}
else if ((num == 0) && (num == 1))
{
    Console.WriteLine(" O Fatorial de {0} é 1." + num);

}
else
{
    for (cont = num; cont >= 1; cont--)
    {
        Console.WriteLine("Seu Calculo é: " + (cont + " " + fatorial));
        fatorial = fatorial * cont;

    }

    Console.WriteLine(" O Fatorial de {0} é {1} " + num + " " + fatorial);
}