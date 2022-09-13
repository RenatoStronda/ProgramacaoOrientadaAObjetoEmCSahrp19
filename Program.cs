// See https://aka.ms/new-console-template for more information
using System;

class Program{
  public static void Main(string[] args)
  {
    Porta p = new Porta(false, "Azul", 1.8f, 1.6f);
    Console.WriteLine(p);
    Console.WriteLine(p.estaAberta());
    p.Pintar("Vermelho");
    Console.WriteLine(p);
    p.Abrir(false);
    Console.WriteLine(p.estaAberta());
    p.setAltura(1.8f);
    p.setLargura(1.9f);
    p.Abrir(true);
    Console.WriteLine(p.estaAberta());
    Console.WriteLine(p);
  }
}
class Porta{
  private bool Aberta { get; set; }
  private string Cor { get; set; }
  private float Altura { get; set; }
  private float Largura { get; set; }

public Porta(bool aberta, string cor, float altura, float largura){
  Aberta = aberta;
  Cor = cor;
  Altura = altura;
  Largura = largura;
}

public void Abrir(bool p){
  if (p == false)
  {
    p = true;
    Aberta = p;
  }
  else
  {
    p = false;
    Aberta = p;
  }
}

public bool estaAberta(){
  return Aberta;
}

public void Pintar(string cor){
  Cor = cor;
}

public void setAltura(float a){
  Altura = a;
}

public void setLargura(float l){
  Largura = l;
}

public override string ToString(){
  return Cor + " " + Aberta + " " + Altura + " " + Largura;
}
}