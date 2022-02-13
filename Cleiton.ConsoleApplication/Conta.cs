using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Itau
{
    public class Conta
    {
        public Conta(string titularInicial, double saldoInicial, string senhaInicial) {
            Titular = titularInicial;
            Saldo = saldoInicial;
            Senha = senhaInicial;
        }

        public string Titular { get; set; }

        private double Saldo { get; set; }

        private string Senha { get; set; }

        public void Sacar(double quantidade)
        {
            Saldo = Saldo - quantidade;
        }

        public void Depositar(double quantidade)
        {
            Saldo = Saldo + quantidade;
        }

        public double VerSaldo(string senhaColocada)
        {
            if (senhaColocada == Senha)
            {
                return Saldo;
            }
            else
            {
                throw new Exception("Senha Inválida");
            }
        }

        public static string VerBanco()
        {
            return "Itau";
        }
    }
}
