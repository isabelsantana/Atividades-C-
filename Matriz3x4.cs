using System;

class MainClass {
  public static void Main (string[] args) {
  
    int [,] valores = new int[3,4];

    for (int x=0; x<3; x++){
      Console.WriteLine("Informe os valores:", x++);
      for (int y=0; y<4; y++){
        valores[x,y] = int.Parse(Console.ReadLine()); 
      }
    }
  }
}
