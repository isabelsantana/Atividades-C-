//Faça um programa que imprima na tela apenas os números ímpares entre 1 e 50.

using System;

class MainClass
{
    public static void Main(string[] args)
    {

        for (int impar = 1; impar <= 50; impar = impar + 2)
        {
            Console.WriteLine(impar);
        }
    }
}