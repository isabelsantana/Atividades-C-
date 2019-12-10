using System;

class MainClass {
  public static void Main (string[] args) {
    
    int[] dados = new int[6] {7,4,5,1,0,3};

    int soma = 0;
    for(int cont=0; cont<6; cont++){
      soma = soma + dados[cont];
    }
    float media = soma / 6f;

    Console.WriteLine("Media calculada "+media);
  }
}
