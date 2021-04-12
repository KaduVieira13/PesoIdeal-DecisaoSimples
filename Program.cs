using System;

namespace PesoIdeal_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal alturaDigitada, pesoResultado;
            string sexoDigitado;
            bool alturaValida;


            Console.WriteLine("--- Peso ideal ---\n");

            Console.Write("Digite sua altura em metros: ");
            alturaValida = decimal.TryParse(Console.ReadLine(), out alturaDigitada);

            if (!alturaValida)
            {
                Console.WriteLine("A altura digitada está inválida");
            }

            Console.Write("Digite M para masculino ou F para feminino: ");
            sexoDigitado = Console.ReadLine().ToUpper();

            if (sexoDigitado.Equals("M"))
            {
                pesoResultado = alturaDigitada * 72.7m - 58;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Seu peso ideal é {pesoResultado:N1}Kg");
            }
            else if (sexoDigitado.Equals("F"))
            {
                pesoResultado = alturaDigitada * 62.1m -44.7m;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Seu peso ideal é {pesoResultado:N1}Kg");
            }
            else
            {
                Console.WriteLine("Sexo do usuário digitado incorretamente, use apenas F ou M");
            }

            Console.ResetColor();

           

        }
    }
}
