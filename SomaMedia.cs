//Faça um programa que leia 5 números e informe a soma e a média dos números.

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int numero, media, soma = 0;

        for (int i = 0; i < 5; i = i + 1)
        {
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            soma = soma + numero;

        }
        media = soma / 5;
        Console.WriteLine("A média é:{0}", media);
    }
}