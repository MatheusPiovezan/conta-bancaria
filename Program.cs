using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Drawing;

namespace conta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria p1;

            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp.Equals('s'))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                p1 = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                p1 = new ContaBancaria(numero, titular);
            }

            Console.WriteLine(p1);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            p1.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(p1);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            p1.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(p1);
        }
    }
}