using System;

namespace CalculadoraIMC
{
    
public class Pessoa {
    public string Nome{get;set;}
    public float Peso{get;set;}
    public float Altura{get;set;}
    public double Imc { get => Peso / (Altura * Altura); }

public Pessoa(string nome, double altura, double peso) { 
        this.Nome = nome;
        this.Altura = altura;
        this.Peso = peso;
    }
  

  public string Situação() {
    
        string resultado = "";

        if(Imc < 17) {
            resultado = "Muito abaixo do peso";
        }

        else if(Imc < 18.5){
            resultado = "Abaixo do peso";
        }

        else if(Imc < 25){
            resultado = "Peso normal";
        }

        else if(Imc < 30){
            resultado = "Acima do peso";
        }

        else if(Imc < 35){
            resultado = "Obesidade I";
        }
            
        else if(Imc < 40){
            resultado = "Obesidade II";
        }

        else{
            resultado = "Obesidade III";
        }

        return resultado;
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


