using Desafio_Estacionamento.Models;


// Colocar o encoding para UFT8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Decimal precoInicial = 0;
Decimal precoPorHora = 0;

// Preço inicial
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
"Digite o preço Inicial");
precoInicial = Convert.ToDecimal(Console.ReadLine());

// Preço por hora
Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());


// Instanciar a classe Estacionamento, ja com valores obtidos atraves do usuario
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção:");
  Console.WriteLine("1 - Cadastrar veículo");
  Console.WriteLine("2 - Remover veículo");
  Console.WriteLine("3 - Listar veículos");
  Console.WriteLine("4 - Encerrar sistema");

  switch (Console.ReadLine())
  {
    case "1":
      es.AdicionarVeiculo();
      break;
    case "2":
      es.RemoverVeiculo();
      break;
    case "3":
      es.ListarVeiculos();
      break;
    case "4":
      exibirMenu = false;
      break;

    default:
      Console.WriteLine("Opção inválida");
      break;
  }

  Console.WriteLine("Pressione uma tecla para continuar");
  Console.ReadLine();
}

Console.WriteLine("Programa Encerrou");

