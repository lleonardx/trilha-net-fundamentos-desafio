namespace DesafioFundamentos.Models
{
    public class Estacionamento
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
            // * IMPLEMENTADO *
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            //Verificar Placa Existente
            // * IMPLEMENTADO *
            if (!veiculos.Contains(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veiculo com Placa {placa} foi adicionado");
            }
            else
            {
                Console.WriteLine($"Veiculo com Placa {placa} ja esta na lista");
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // * IMPLEMENTADO *
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    //Definido valor do preco inicial e preco por hora
                    // * IMPLEMENTADO *
                    decimal precoInicial = 5.00M;
                    decimal precoPorHora = 2.00M;
                    // * IMPLEMENTADO *
                    decimal valorTotal = precoInicial + (precoPorHora * horas);

                    veiculos.Remove(placa);

                    Console.WriteLine($"O veiculo {placa} foi removido e o preco total foi de: {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Por favor, insira um valor válido para a quantidade de horas.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // * IMPLEMENTADO *
                foreach (string placa in veiculos)
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
