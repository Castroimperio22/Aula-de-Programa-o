/* Verificar a ordem num1 > num2 > num3
Verificar a ordem num1 > num3 > num2
Verificar a ordem num2 > num1 > num3
Verificar a ordem num2 > num3 > num1
Verificar a ordem num3 > num1 > num2
Verificar a ordem num3 > num2 > num1
*/


int num1, num2, num3, maior = 0, meio = 0, menor = 0;

Console.WriteLine(" Digite o Primeiro Valor: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Digite o Segundo Valor: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Digite o Terceiro Valor: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 && num1 == num3 && num2 == num3)
{
    Console.WriteLine(" Número são Iquais ou seja sua entrada e Invalida: ");
}
else
{
    if (num1 > num2 && num1 > num3)
    {
        maior = num1;

        if (num2 > num3)
        {
            meio = num2;
            menor = num3;
        }
        else
        {
            meio = num3;
            menor = num2;
        }
    }

    else
    {
        if (num2 > num1 && num2 > num3)
        {
            maior = num2;

            if (num1 > num3)
            {
                meio = num1;
                menor = num3;
            }

            else
            {
                meio = num3;
                menor = num1;
            }
        }


        else
        {
            if (num3 > num1 && num3 > num2)
            {
                maior = num3;

                if (num1 > num2)
                {
                    meio = num1;
                    menor = num2;
                }

                else
                {
                    meio = num2;
                    menor = num1;
                }
            }

        }
    }
}

Console.WriteLine(" A Sua Ordem Decrescente é: " + num1 + " Vai receber o Maior "
  + num2 + " Vai receber o do" + " E o Ultimo vai receber o menor " + num3);
