public class Pessoa {
    public string Nome{get;set;}
    public float Peso{get;set;}
    public float Altura{get;set;}
    public double Imc { get; set;}

        //public Pessoa(double Peso, double Altura)
        //{
        //Altura = Altura;
        // Peso = Peso;
        //}
        public double Resultado(){
            var imc = Peso / (Altura * Altura);
            return imc;
        }
    }




