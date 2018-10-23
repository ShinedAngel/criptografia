using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Diego
{
    class Program
    {
        //Crie um programa em C# que determina se o cliente de uma loja de departamentos ultrapassou o limite de crédito em uma conta.
        public class Cliente
        {
            private int saldo;
            private int conta;
            private int totalCobrancas;
            private int totalCredito;
            private int limiteCredito;

            public Cliente(int saldo, int conta, int cobrancas, int credito, int limite)
            {
                this.saldo = saldo;
                this.conta = conta;
                this.totalCobrancas = cobrancas;
                this.totalCredito = credito;
                this.limiteCredito = limite;
            }
            public int CalcularNovoSaldo()
            {
                return this.saldo + this.totalCobrancas - this.totalCredito;
            }

            public void AtualizarSaldo()
            {
                this.saldo = CalcularNovoSaldo();
            }

            public bool UltrapassouLimite()
            {
                return this.saldo > this.limiteCredito;
            }
        }

        static void Main(string[] args)
        {

            /*Seu aplicativo deve ler um inteiro de quatro dígitos fornecidos pelo usuário e criptografá-lo da seguinte forma:
            substitua cada dígitos por(a soma desse dígitos mais 7) módulo 10.Em seguida, troque o primeiro dígito
            pelo terceiro e troque o segundo dígito pelo quarto e imprima o inteiro criptografado.*/


            //Questão 02
            Console.WriteLine("Digite o saldo atual ");
            int saldo = int.Parse(Console.ReadLine());

            Cliente c = new Cliente(saldo, 20, 30, 200, 1000);

            Console.WriteLine("O seu novo saldo é de ");
            Console.WriteLine(c.CalcularNovoSaldo());

            c.AtualizarSaldo();
            Console.ReadKey();
            if (c.UltrapassouLimite())
            {
                Console.WriteLine("Limite de crédito excedido!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Há crédito disponível.");
                Console.ReadKey();
            }

            /*Implemente em C# a função booleana Par que retorna verdadeiro se um número inteiro passado como parâmetro
            for par ou falso caso ele seja ímpar*/
            int a = 0;

            Console.WriteLine("\nDigite um Numero");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }
            Console.ReadKey();

            /*Escreva um programa que leia 3 números inteiros referente ao comprimento dos lados de um triângulo e classifique como:
            triângulo equilátero, isósceles ou escaleno.*/
            int num1, num2, num3;

            Console.WriteLine("\nMe informe um número inteiro");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Me informe outro número inteiro");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Me informe mais um número inteiro");
            num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 == num2 && num1 == num3 && num2 == num3)
            {
                Console.WriteLine("Triângulo equilátero");
            }
            else if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                Console.WriteLine("Triângulo escaleno");
            }
            else
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            Console.ReadKey();

            //Escreva um programa que leia apenas uma letra do alfabeto como entrada e classifique-a como vogal ou consoante.
            char caracter;
            bool vogal = false;

            string[] vogais = new string[] { "a", "e", "i", "o", "u" };

            Console.Write("Informe uma letra: ");
            char.TryParse(Console.ReadLine(), out caracter);

            for (int i = 0; i < vogais.Length; i++)
            {
                if (vogais[i] == caracter.ToString())
                {
                    vogal = true;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (vogal)
            {
                Console.WriteLine("Esta letra é VOGAL.");
            }
            else
            {
                Console.WriteLine("Esta letra é CONSOANTE.");
            }

            //“Um número é primo se ele for divisível por 1 e por ele mesmo”. Escreva um programa C# que verifica se um número é primo.
            int n = 0, cont = 0;

            Console.WriteLine("\nInforme um número");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                Console.WriteLine("O numero"+n+" é primo.");
            }
            else
            {
                Console.WriteLine("O numero"+n+" não é primo!");
            }

            Console.ReadKey();
        }
    }
}