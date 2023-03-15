// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde_GitHub;
using ConsoleApp_Tarde_GitHub.Heranca;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;


Produto p1 = new Produto(1, "Mouse xing ling", 10.90M);
Produto p2 = new Produto(2, "Teclado Multilaser", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco(1,"15906304", "Mario Miziara", 91, "Sobral", "Taquaritinga");

Cliente c1 = new Cliente(1, "Fernando", "991240447", e1);
Cliente c2 = new Cliente(2, "Victoria", "9879040447", e1);
Cliente c3 = new Cliente(3, "Rafael", "991123447", e1);
Cliente c4 = new Cliente(4, "Lucas", "991268747", e1);
Cliente c5 = new Cliente(5, "Eduardo", "9912350447", e1);

Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().AtualizarEndereco("Julio de Morais", 585, "Portal Itamaraca");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());


Carro car = new Carro();
car.cor = "Vermelho";
car.quantidadeRodas = 4;
car.quantidadeAssentos = 5;
car.TemMotor = true;

Bike bicicleta = new Bike();
bicicleta.cor = "Azul";
bicicleta.quantidadeAssentos = 1;
bicicleta.quantidadeRodas = 2;
bicicleta.TemMotor = false;

Aviao aviao = new Aviao();
aviao.cor = "Branco";
aviao.quantidadeAssentos = 200;
aviao.quantidadeRodas = 18;
aviao.TemMotor = true;

List<Veiculo> veiculoLista = new List<Veiculo>();

veiculoLista.Add(car);
veiculoLista.Add(aviao);
veiculoLista.Add(bicicleta);

foreach (var item in veiculoLista)
{
    Console.WriteLine(item.ExibirDados());
}



Console.WriteLine("Quantidade de itens da lista" + veiculoLista.Count);

//Crie duas Listas
//Uma lista de Produtos com 400 produtos
//Outra lista de Cliente com 250 clientes

Random rand = new Random();

List<Produto> produtoLista = new List<Produto>();

for(int i = 0; i < rand.Next(200, 500) ; i++)
{
    Produto p = new Produto(i, "Produto " + i, i / 2 * 3);
    produtoLista.Add(p);
    
}

foreach (var item in produtoLista)
{
    Console.WriteLine(item.ExibirDados());
}

List<Cliente> clienteLista = new List<Cliente>();

for(int i = 0; i < rand.Next(200, 500); i++)
{
    Endereco e = new Endereco(1, "Rua", "05309583049", i*2, " ", " " );
    Cliente c = new Cliente(i, "Cliente " + i, "Telefone "+ i, e );
    clienteLista.Add(c);
}

foreach (var item in clienteLista)
{
    Console.WriteLine(item.ExibirDados());
}
