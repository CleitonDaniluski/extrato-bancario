using Banco.Itau;

Console.WriteLine("Iniciando");

var contaDoChico = new Conta("Chico", 10000, "123456");
var contaDoDark = new Conta("Dark", 10000, "123456"); 

List<Conta> todasContas = new List<Conta>() { contaDoChico , contaDoDark };

contaDoChico.Sacar(80);
contaDoDark.Depositar(80);

foreach (Conta conta in todasContas)
{
    Console.WriteLine($"Titular da conta é:{conta.Titular}, Saldo da conta é:{conta.VerSaldo("123456")}");
}

Console.WriteLine(Conta.VerBanco());

Console.WriteLine("Finalizando");
