using System;
class MainClass{
  public static void Main (string[] arg){
    double b, h, a;
    Console.WriteLine("Digite a base do triangulo");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a altura do triangulo");
    h = double.Parse(Console.ReadLine());
    a = b * h / 2;
    Console.WriteLine($"Área = {a:0.00}");
  }
}