using System;

class MainClass{
    public static bool Primo(int numero){

        int qtdDivisores = 0;

        for (int i = numero; i > 0; i--){
            if (numero % i == 0)
                qtdDivisores++;
        }

        return qtdDivisores > 2 ? false : true;
    }

    static void Main(string[] args){

        int[] vetor = new int[] { 1, 8, 15, 7, 17, 1, 4, 2, 3, 12 };

        for (int i = 0; i < vetor.Length; i++)
        {
            if (Primo(vetor[i]))
                Console.WriteLine("Elemento do índice {0}: {1}", i, vetor[i]);
        }

        Console.ReadKey();
    }

}