using Atividade04Ex08;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            GerenciamentoDeEstacionamento estacionamento = new GerenciamentoDeEstacionamento(10); // Define a capacidade do estacionamento.

            Console.WriteLine($"Vagas disponíveis: {estacionamento.VagasDisponiveis}");

            estacionamento.EstacionarCarro();
            Console.WriteLine($"Vagas disponíveis após estacionar um carro: {estacionamento.VagasDisponiveis}");

            estacionamento.SairDoEstacionamento();
            Console.WriteLine($"Vagas disponíveis após um carro sair: {estacionamento.VagasDisponiveis}");

            for (int i = 0; i < 10; i++)
            {
                estacionamento.EstacionarCarro(); // Tentando estacionar mais carros do que a capacidade
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}