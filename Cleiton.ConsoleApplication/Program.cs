using Batata;

Console.WriteLine("Iniciando");

int umNumeroInteiro = 5; 
double umNumeroDecimal = 5.0;
string frase = "Alguma coisa escrita 5555555555555";
string[] cpfsFamilia = new string[] {"5555555555555", "4444444444444444", "8888888888888888" };
List<string> cpfsFamiliaLista = new List<string>() {"5555555555555", "4444444444444444", "8888888888888888" };

frase = umNumeroInteiro.ToString();
cpfsFamiliaLista.Add("333333333333333333");
cpfsFamiliaLista.Remove("333333333333333333");

var minhaNovaVariavel = $"{umNumeroInteiro}{umNumeroDecimal}";
Console.WriteLine(minhaNovaVariavel);

var carro1 = new Carro();
carro1.Modelo = "Civic";
carro1.Cor = "Prata";
carro1.Barulho = "Vruuuuuuuum";

var carro2 = new Carro();
carro2.Modelo = "Uno";
carro2.Cor = "Verde";
carro2.Barulho = "Nhec Nhec";

Console.WriteLine(carro2.Acelerar());



Console.WriteLine("Finalizando");
