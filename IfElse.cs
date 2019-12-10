//Faça um programa em C# que recebe um número inteiro representando um valor de hora e exibe uma saudação para o usuário (bom dia, boa tarde ou boa noite) conforme a hora informada.

using System;

class MainClass {
  public static void Main (string[] args) {
    
    int num = 0;
      Console.WriteLine("Digite uma hora: ");
      num = int.Parse(Console.ReadLine());

      if (num > 0 && num < 12){
      Console.WriteLine("Bom dia!");
      }  
  
      else{

      if (num >= 12 && num <= 18) {
      Console.WriteLine("Boa tarde!");
      }


      else {
        Console.WriteLine("Boa noite!");
      }
    }
  }
}


