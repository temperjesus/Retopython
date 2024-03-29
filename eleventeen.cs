//herencia
class Carro :MedioTransporte{
  private int ruedas {get;set;}
  public Carro(int codigo , String marca, int ruedas):base(codigo,marca ){
   this.Codigo=codigo;
   this.Marca=marca;
   this.ruedas=ruedas;
  }
  public void GetIn(){
     Console.WriteLine($"Marca {this.Marca} and Codigo {this.Codigo} and ruedas {this.ruedas}");
  }

}
