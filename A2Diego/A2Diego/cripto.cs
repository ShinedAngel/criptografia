using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cripto
{
    class Program
    {
        
        public static void Main()
        {
            const int DECIMAL = 10;

            string digitos4 = "";
            int intdigitos4 = 0;
            int unidade = 0;
            int dezena = 0;
            int centena = 0;
            int unidadeDeMilhar = 0;
            int restoDivisao = 0;
            int quociente = 0;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\tDIGITE UM NÚMERO INTEIRO COM QUATRO DÍGITOS: ");
            Console.ResetColor();
            digitos4 = Console.ReadLine();

            if (digitos4.Contains(" "))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tPOR FAVOR, NÃO UTILIZE ESPAÇOS");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\n\tDIGITE UM NÚMERO INTEIRO COM QUATRO DÍGITOS: ");
                Console.ResetColor();
                digitos4 = Console.ReadLine();
            }else
            {
                intdigitos4 = Convert.ToInt32(digitos4);

                restoDivisao = intdigitos4 % DECIMAL;
                quociente = intdigitos4 / DECIMAL;
                unidade = restoDivisao;

                restoDivisao = quociente % DECIMAL;
                quociente = quociente / DECIMAL;
                dezena = restoDivisao;

                restoDivisao = quociente % DECIMAL;
                quociente = quociente / DECIMAL;
                centena = restoDivisao;

                restoDivisao = quociente % DECIMAL;
                unidadeDeMilhar = restoDivisao;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n\t\tSEU NÚMERO CRIPTOGRAFADO: ");
            Console.ResetColor();
            Console.WriteLine("{2} {3} {0} {1}", unidadeDeMilhar + 7, centena + 7, dezena + 7, unidade + 7);
            
            Console.ReadKey();
        }
    }
}
