using System;

namespace alimentos {

  class MainClass {
    
    public static void Main (string[] args) {
    
    Comida bolo = new Comida();
    bolo.Alimentar();
    bolo.Decorar();
    bolo.Preparar();
    bolo.Servir();
    
    }
  }
}
