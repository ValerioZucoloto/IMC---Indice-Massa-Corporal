using System;

class MainClass {
  public static void Main (string[] args) {
    float altura=0f, peso=0f;
    int idade=0;
    string nome;

    Console.WriteLine ("Informe o nome: ");
    nome = Console.ReadLine();

    Console.WriteLine("Informe a idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine ("Informe a altura: ");    
    altura = float.Parse(Console.ReadLine());

    Console.WriteLine ("Informe o peso: ");    
    peso = float.Parse(Console.ReadLine());

    float IMC = peso / (altura*altura);

    Console.WriteLine ("Nome: {0} - idade: {1}", nome, idade);
    Console.WriteLine("IMC: {0}",IMC);

  }
}