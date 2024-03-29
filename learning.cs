
Carro cohe= new Carro(3,"s",6);

cohe.GetIn();
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
class MedioTransporte
{
  private int codigo;
  private String marca;
 //Constructor
  public MedioTransporte(int codigo, String marca)
  {
    this.codigo = codigo;
    this.marca = marca;
  }
  //Set and getter
  public int Codigo { get => codigo; set => codigo = value; }
  public String Marca { get => marca; set => marca = value; }

  public void  GetInfo(){
    Console.WriteLine($"Marca {this.Marca} and Codigo {this.Codigo}"); 
  }
}
