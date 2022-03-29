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

            if (imc < 17.00){
                Console.WriteLine("Muito Abaixo do Peso");
            }

            else if(imc >= 17.0 && imc < 18.50){
                    Console.WriteLine("Abaixo do peso");
            } 
            
            else if (imc >= 18.50 && imc < 25.00){
                    Console.WriteLine("Peso normal");
            } 
            
            else if (imc >= 25.00 && imc < 30.00){
                    Console.WriteLine("Acima do peso");
            } 
            
            else if (imc >= 30.00 && imc < 35.00){
                    Console.WriteLine("Obesidade I");
            }
            
            else if (imc >= 35.00 && imc < 40.00){
                    Console.WriteLine("Obesidade II (Severa)");
            }
            
            else {
                Console.WriteLine("Obesidade III (Mórbida)");
            }
          
        }
    }
}
