using System;

class MainClass
{
    public static void Main(string[] args)
    {

        int soma = 0;
        for (int num = 1; num < 21; num++)
        {

            if (num % 3 == 0)
            {

                soma = soma + num;
            }
        }

        Console.WriteLine($"A soma é {soma}");

    }
}