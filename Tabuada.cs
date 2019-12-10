//Faça um programa que leia um número inteiro e imprima a tabuada deste número de zero a nove. Interrompa o processamento quando ler um número menor que zero.

using System;

class MainClass {
  public static void Main (string[] args) {

    int aux = 1;
    int num = 0;
    int conta = 0;

      Console.WriteLine("Digite um numero para ver sua tabuada: ");
      num = int.Parse(Console.ReadLine());
  
    while (aux <=10){
    
      conta = (num*aux);
      Console.WriteLine("{0} x {1} = {2}", num, aux,conta);
      aux +=1;
    }
  }
}
