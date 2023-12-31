namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 5;
        private decimal precoPorHora = 2;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public bool VeiculoEstacionado(string placa)
        {
            return veiculos.Any(x => x.ToUpper() == placa.ToUpper());
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

             if (VeiculoEstacionado(placa))
            {
                Console.WriteLine("Esse veículo já está estacionado. Não é possível adicioná-lo novamente.");
            }
             else
            {

            veiculos.Add(placa);
            Console.WriteLine("O veículo foi estacionado com sucesso!");
            }
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();


            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                

                if (int.TryParse(Console.ReadLine(), out int horas))
                {

                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
