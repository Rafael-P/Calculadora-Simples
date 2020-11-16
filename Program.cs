using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação que deseja fazer \nSoma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1º  número");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            switch(operacao){

                case "Soma":
                    resultado = num1+num2;
                    break;

                case "Subtracao":
                    resultado = num1-num2;
                    break;

                case "Multiplicacao":
                    resultado = num1*num2;
                    break;

                case "Divisao":
                    resultado = num1/num2;
                    break;

                default:
                    Console.WriteLine("Operação inválida");
                    break;            
            }

            Console.WriteLine($"Calculo : {num1} e {num2} = Resultado : {resultado}");

        }//fim do main
    }
}
