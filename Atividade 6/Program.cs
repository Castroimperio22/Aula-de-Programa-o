/*6.Faça um programa que receba o valor de um carro e mostre uma tabela com os seguintes 
 * dados: preço final, quantidade de parcelas e valor da parcela. Considere o seguinte: 
O preço final para compra à vista tem um desconto de 20%;
A quantidades de parcelas pode ser: 6, 12, 18, 24, 30, 36, 42, 48, 54 e 60. 
Os percentuais de acréscimo seguem a tabela a seguir.  


Quantidade de Parcelas => Percentual de acréscimo sobre o preço final
6 => 3%
12 => 6%
18 => 9%
24 => 12%
30 => 15%
36 => 18%
42 => 21%
48 => 24%
54 => 27%
60 => 30%
*/

decimal precoCarro, precoParcela = 0, quantidadeParcela = 0, desconto = 0_2, precoFinal = 0;

Console.WriteLine(" Digite o Preço do Carro Desejando: ");
precoCarro = Convert.ToDecimal(Console.ReadLine());

if(precoCarro == )
{
    precoFinal = precoFinal + precoFinal + (precoCarro - desconto);
}

else
{
    Console.WriteLine(" Digite a Quatidade de parcela que deseja dividir: ");
    quantidadeParcela = Convert.ToDecimal(Console.ReadLine());

    if(quantidadeParcela == 6)
    {
        precoFinal = (precoFinal * 0_03m);
        precoParcela = precoFinal / quantidadeParcela;
    }

    if(quantidadeParcela == 12)
    {
        precoFinal = (precoFinal * 0_06m);
        precoParcela = precoFinal / quantidadeParcela;
    }

    if(quantidadeParcela == 18)
    {
        precoFinal = (precoFinal * 0_09m);
        precoParcela = precoFinal / quantidadeParcela;
    }

    if(quantidadeParcela == 24)
    {
        precoFinal = (precoFinal * 0_12m);
        precoParcela = precoFinal / quantidadeParcela;
    }

    if(quantidadeParcela == 30)
    {
        precoFinal = (precoFinal * 0_15m);
        precoParcela = precoFinal / quantidadeParcela;
    }

    if (quantidadeParcela == 36)
    {
        precoFinal = (precoFinal * 0_18m);
        precoParcela = precoFinal / quantidadeParcela;
    }

    if(quantidadeParcela == 42)
    {
        precoFinal = (precoFinal * 0_21m);
        precoParcela = precoFinal / quantidadeParcela;
    }

    if(quantidadeParcela == 48)
    {
        precoFinal = (precoFinal * 0_24m);
        precoParcela = precoFinal / quantidadeParcela;
    }
    
    if(quantidadeParcela == 54)
    {
        precoFinal = (precoFinal * 0_27m);
        precoParcela = precoFinal / quantidadeParcela;
    }

    if(quantidadeParcela == 60)
    {
        precoFinal = (precoFinal * 0_3m);
        precoParcela = precoFinal / quantidadeParcela;
    }

}

Console.WriteLine(" O Preço Final foi de: " + precoFinal);
Console.WriteLine(" A Quantidade de Parcela Foi de: " + quantidadeParcela);
Console.WriteLine(" O Preço Final da Parcela foi de: " + precoParcela);

