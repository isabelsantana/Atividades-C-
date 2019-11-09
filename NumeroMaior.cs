//Faça um programa em C# que recebe 3 números e imprime na tela o maior dos 3 números.

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int num1, num2, num3;
        Console.WriteLine("Digite um numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um numero: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um numero: ");
        num3 = int.Parse(Console.ReadLine());

        if (num1 > num2 & num1 > num3)
        {
            Console.WriteLine("Numero 1 é o maior numero!" + num1);
        }
        if (num2 > num1 & num2 > num3)
        {
            Console.WriteLine("Número 2 é o maior numero!" + num2);
        }
        if (num3 > num1 & num3 > num2)
        {
            Console.WriteLine("Numero 3 é o maior numero!" + num3);
        }

    }
}