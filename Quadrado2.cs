//Classe Quadrado: Crie uma classe que modele um quadrado:

//Atributos: Tamanho do lado
//Métodos: Mudar valor do Lado, Retornar valor do Lado e calcular Área;


class Quadrado {
  //Atributos ou caracteristicas

  private int lado;


    public void trocaLado(int l){
      lado = l;
    }
    
    public int retornaLado(){
      return lado;
    }

    public int area(){
      return lado*lado;
    }

  }
