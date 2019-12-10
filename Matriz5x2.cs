using System;

class MainClass {
  public static void Main (string[] args) {
   
  int[,] numeros = new int[5,2];

    for(int i=0; i<5; i++){
    Console.WriteLine("Informe os numeros da linha:",i+1);
      for(int j=0; j<2; j++){
        numeros[i,j] = int.Parse(Console.ReadLine());
      }
    }

    for(int i=0; i<5; i++){ 
      for(int j=0; j<2; j++){ 
        Console.Write("{0}  ", numeros[i,j]);
      }
      Console.WriteLine();
    }   
  }
}
