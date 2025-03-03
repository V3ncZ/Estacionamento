using ProjetoVeiculos.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        decimal precoInicial;
        decimal precoPorHora;

        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");


        Console.WriteLine("Digite o preco inicial para usar o estacionamento: ");
        precoInicial = Convert.ToDecimal(Console.ReadLine()!);
        Console.WriteLine("Digite o valor da hora: ");
        precoPorHora = Convert.ToDecimal(Console.ReadLine()!);

        Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

        int resposta;

        do
        {
            Console.WriteLine("\n1- Adicionar placa do veiculo\n2- Remover Veiculo\n3- Listar carros\n4- Sair");
            Console.WriteLine("Escolha uma opção: ");
            resposta = int.Parse(Console.ReadLine()!);

            switch (resposta)
            {
                case 1:
                    estacionamento.AdicionarVeiculo();
                    break;
                case 2:
                    estacionamento.RemoverVeiculo();
                    break;
                case 3:
                    estacionamento.ListarCarros();
                    break;
                case 4:
                    Console.WriteLine("\nObrigado por usar nosso sitema!");
                    break;
                default:
                    Console.WriteLine("insira uma opção válida!");
                    break;
            }


        } while (resposta != 4);
    }
}