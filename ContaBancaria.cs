using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace conta
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }
        public ContaBancaria(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo = (Saldo - quantia) - 5;
        }

        public override string ToString()
        {
            return $"Dados da conta:\n" +
                $"Conta: {this.NumeroConta}, Titular: {this.Titular}, Saldo: R$ {this.Saldo}";
        }
    }
}
