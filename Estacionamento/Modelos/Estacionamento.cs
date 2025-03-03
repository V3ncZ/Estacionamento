namespace ProjetoVeiculos.Modelos;

internal class Estacionamento
{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;

    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("\nInforme a placa do carro: ");
        string veiculo = Console.ReadLine()!;
        veiculos.Add(veiculo);
        Console.WriteLine($"Carro com a placa {veiculo} adicionado ao estacionamento!");
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veiculo que deseja retirar: ");
        string placaDoVeiculo = Console.ReadLine()!;
        if (veiculos.Any(x => x.ToUpper() == placaDoVeiculo.ToUpper())) {
            veiculos.Remove(placaDoVeiculo);
            Console.WriteLine("Informe a quantidade de horas que o veiculo ficou estacionado: ");
            decimal hora = Decimal.Parse(Console.ReadLine()!);
            decimal precoTotal = (hora * precoPorHora) + precoInicial;
            Console.WriteLine($"O veiculo {placaDoVeiculo} foi removido e o total a pagar é: R${precoTotal}");
        } else
        {
            Console.WriteLine("Veiculo não encontrado!");
        }
    }

    public void ListarCarros()
    {
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine(veiculo);
        }
    }
}
