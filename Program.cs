using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Calculadora de IMC");
            Console.WriteLine("Digite o seu peso: ");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            float resultado = peso / (altura * altura);
            
            //Console.Clear();
            
            if(resultado < 18.5){
                Console.WriteLine("Resultado: " + resultado.ToString("F"));
                Console.WriteLine("Abaixo do peso");
            }
            else if((resultado >= 18.5) && (resultado <= 24.9)){
                Console.WriteLine("Resultado: " + resultado.ToString("F"));
                Console.WriteLine("Peso Normal");
            }
            else if((resultado == 25) && (resultado <= 29.9)){
                Console.WriteLine("Resultado: " + resultado.ToString("F"));
                Console.WriteLine("Sobrepeso");
            }
            else if((resultado == 30) && (resultado <= 34.9)){
                Console.WriteLine("Resultado: " + resultado.ToString("F"));
                Console.WriteLine("Obesidade Grau 1");
            }
            else if((resultado == 35) && (resultado <= 39.9)){
                Console.WriteLine("Resultado: " + resultado.ToString("F"));
                Console.WriteLine("Obesidade Grau 2");
            }
            else if(resultado > 40){
                Console.WriteLine("Resultado: " + resultado.ToString("F"));
                Console.WriteLine("Obesidade Grau 3 (Mórbida)");
            }

             Console.ReadKey();
        }

    }
}
