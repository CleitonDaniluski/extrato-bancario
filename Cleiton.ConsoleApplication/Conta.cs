using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Itau
{

     public enum TransacaoTipo 
      {
        [Description("Deposito")]
        Deposito = 10,
        [Description("Saque")]
        Saque = 20,
        [Description("Transferencia")]
        Transferencia = 30,
      } 

    public class Conta
    {

        public Conta(string titularInicial, double saldoInicial, string senhaInicial)
        {
            Titular = titularInicial;
            Saldo = saldoInicial;
            Senha = senhaInicial;
            Transacoes = new List<TransacaoBancaria>();
        }

        public string Titular { get; set; }

        private double Saldo { get; set; }

        private string Senha { get; set; }

        public List<TransacaoBancaria> Transacoes { get; set; }

        public void Sacar(double quantidade)
        {
            Saldo = Saldo - quantidade;
            Transacoes.Add(new TransacaoBancaria(this, quantidade, TransacaoTipo.Saque));
        }

        public void Depositar(double quantidade)
        {
            Saldo = Saldo + quantidade;
            Transacoes.Add(new TransacaoBancaria(this, quantidade, TransacaoTipo.Deposito));
        }

        public void Transferencia(double transferencia, Conta contaDestino)
        {
            Saldo = Saldo - transferencia;
            contaDestino.Depositar(transferencia);
            Transacoes.Add(new TransacaoBancaria(this, transferencia, TransacaoTipo.Transferencia));
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
    public class TransacaoBancaria
    {
        public string Titular { get; }
        public double Saldo { get; set; }

        public TransacaoTipo TransacaoTipo;

        public TransacaoBancaria(Conta conta, double valor, TransacaoTipo transacaoTipo)
        {
            Titular = conta.Titular;
            Saldo = valor;
            TransacaoTipo = transacaoTipo;
        }
    }
}


