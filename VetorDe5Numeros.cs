// Faça um Programa que leia um vetor de 5 números inteiros e mostre-os.

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int tam = 5;
        int[] meuVet = new int[tam];
        for (int i = 0; i < tam; i++)
        {
            Console.WriteLine("Valor: {0}", i + 1);
            meuVet[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < tam; i++)
        {
            Console.Write("{0} - ", meuVet[i]);
        }
    }
}
