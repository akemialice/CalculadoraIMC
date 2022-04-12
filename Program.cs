using System;

namespace CalculadoraIMC
{
        class Program { 
         static void Main(string[] args) {
           
          Console.WriteLine("Entre com o seu nome:");
          string Nome = Console.ReadLine();

          Console.WriteLine("Entre com a sua altura em metros:");
          double Altura = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Entre com o peso em quilogramas:");
          double Peso = Convert.ToDouble(Console.ReadLine());

          Individuo i1 = new Individuo(nome, altura, peso);

          Console.WriteLine("{0}, seu peso é {1}kg, sua altura é {2}", i1.Nome, i1.Altura, i1.Peso);
          Console.WriteLine("Seu IMC é {0}", i1.imc);
          Console.WriteLine(i1.FaixaAtual());
          Console.WriteLine(i1.PesoIdeal());
        }
    }
