using System;

class MainClass {
  public static void Main (string[] args) {
    
    int voto = 0;
    int[] jogadores = new int[23];

 // Console.WriteLine("Digite um numero r: ");
 // voto = int.Parse(Console.ReadLine()); 
    
    while (true){    //voto!=0){
      Console.WriteLine("Digite um numero: ");
      voto = int.Parse(Console.ReadLine());

      if(voto == 0){
        Console.WriteLine("Votação cancelada");
        break;
      }

      else if(voto > 23 || voto < 1){
        Console.WriteLine("O numero é inválido, digite outro");
      }

      else{
        jogadores[voto] = jogadores[voto] + 1;
      }
    }

    Console.WriteLine("Resultado da Votação");
      for(int i = 0; i <= 23; i++){
        Console.WriteLine(i);
          if (jogadores[i] > 0){
        //Console.WriteLine("{0} - {1}",i+1,jogadores[i]);
            Console.WriteLine("{0} - {1}",i,jogadores[i]);
          }
      }    
  }
}
