using System;

namespace CalculadoraIMC
{
    
public class Pessoa {
    public string Nome{get;set;}
    public float Peso{get;set;}
    public float Altura{get;set;}
    public double imc { get => Peso / (Altura * Altura); }

public Pessoa(string nome, double altura, double peso) { 
        this.Nome = nome;
        this.Altura = altura;
        this.Peso = peso;
    }
  

  public string FaixaAtual() {
    
         if(imc<17.00){
             return "Você está muito abaixo do peso!\n";
            }
            else if (imc >=17.00 && imc <18.50) {
                return "Você está abaixo do peso!\n";
            }
            else if(imc>=18.50 && imc <25.00){
                return "Você está no peso normal!\n";
            }
            else if (imc >=25.00 && imc <30.00){
                return "Você está acima do peso.\n";
            }
            else if (imc >=30.00 && imc <35.00){
                return "Você está obeso - Obesidade Grau I\n";
            }
            else if (imc >=35.00 && imc <40.00){
                return "Você está obeso - Obesidade Grau II (severa)\n";
            }
            else {
                return "Você está obeso - Obesidade Grau III (mórbida)\n";
            }
                return -1;
    }
  
 public double PesoIdeal(){
   
   if(imc < 18.50){
      double pesoNecessario = ((18.5*Peso)/imc) -Peso;
      Console.WriteLine("Para chegar ao peso ideal, você precisa ganhar:");
        return pesoNecessario;
  } else if(imc >= 25) {
      double pesoNecessario = Peso- ((24.99*Peso)/imc);
      Console.WriteLine("Para chegar ao peso ideal, você precisa perder:");
        return pesoNecessario;
        }
      Console.WriteLine("Você já está no peso ideal!");
   
    }
}


