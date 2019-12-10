using System;

class MainClass {
  public static void Main (string[] args) {
    char[,] letras = new char[3,4];

    //Leitura de dados
    for(int i=0; i<3; i++){
      Console.WriteLine("Informe as letras para a {0}ª linha",i+1);
      for(int j=0; j<4; j++){
        letras[i,j] = char.Parse(Console.ReadLine());
      }
    }

    //Processamento dos dados:

    for(int i=0; i<3; i++){
      for(int j=0; j<4; j++){        
        char ch = letras[i,j];
          if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u'){
          Console.WriteLine(ch);
        } 
      }
    }
  }
}
