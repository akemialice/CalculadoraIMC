using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu peso:");
            float peso = Convert.ToSingle(Console.ReadLine());   

            Console.WriteLine("Digite sua altura:");
            float altura = Convert.ToSingle(Console.ReadLine());    

            float imc = peso /(altura*altura);

            Console.WriteLine("{0}, sua altura é {1} e seu peso {2}.", nome, altura, peso);
            Console.WriteLine("Seu IMC é {0}", imc);
          
        }
    }
}
