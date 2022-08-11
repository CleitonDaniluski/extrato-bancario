using Banco.Itau;
using Cleiton.ConsoleApplication;
using System.ComponentModel;

Console.WriteLine("Iniciando");

var contaDoChico = new Conta("Chico", 10000, "123456");
var contaDoDark = new Conta("Dark", 10000, "123456"); 

List<Conta> todasContas = new List<Conta>() { contaDoChico , contaDoDark };

contaDoChico.Transferencia(500, contaDoDark);
contaDoChico.Sacar(300);
contaDoChico.Depositar(1000);
contaDoChico.Depositar(200);
contaDoChico.Sacar(2300);

contaDoDark.Sacar(100);
contaDoDark.Transferencia(1200, contaDoChico);
contaDoDark.Depositar(300);



foreach (Conta conta in todasContas)
{
    Console.WriteLine($"\nTitular da conta: {conta.Titular}");

    Console.WriteLine($"\nExtrato De: {conta.Titular}\n");
    foreach (TransacaoBancaria transacaoBancaria in conta.Transacoes)
    {
        Console.WriteLine($"{transacaoBancaria.TransacaoTipo.GetDescription()} de: {transacaoBancaria.Saldo}");
    }
    Console.WriteLine($"\nSaldo da Conta: {conta.VerSaldo("123456")}");
}

Console.WriteLine("\nFinalizando");
