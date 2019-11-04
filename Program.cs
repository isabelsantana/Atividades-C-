// Faça um programa que leia 5 números e informe o maior número.


using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int numero, maior;

        numero = int.Parse(Console.ReadLine());
        maior = numero;

        for (int i = 0; i < 5; i = i + 1)
        {
            numero = int.Parse(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }
        }
        Console.WriteLine(maior);

    }
}

