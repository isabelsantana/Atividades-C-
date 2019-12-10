using System;

  class MainClass {
    
    public static void Main (string[] args) {
    
   Quadrado valor = new Quadrado(); 
    valor.trocaLado(5);
   
    Console.WriteLine("O valor do lado é: {0}",valor.retornaLado());
    
    Console.WriteLine("O resultado do cálculo da área é: {0}",
    valor.area());
    }
  }

