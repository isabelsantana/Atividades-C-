using System;

namespace alimentos {

  class Comida {

    public string cor;
    private string textura;
    private string tipo;
    public float valorNutricional;

    public string getTextura(){
      return textura;  
    } 
    public void setTextura(string t){
      textura = t;
    }

    public void Alimentar(){
      Console.WriteLine("Pode comer.");
    }

    public void Decorar(){
      Console.WriteLine("Comida feita para decorar");
    }
    public void Preparar(){
      Console.WriteLine("Comida em preparação.");
    }
    public void Servir(){
      Console.WriteLine("Pode servir a comida.");
    } 

  }
}
