using Atividade04Ex09;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            GerenciamentoDeReservas gerenciador = new GerenciamentoDeReservas();

            gerenciador.AdicionarReserva(DateTime.Parse("2023-09-16 19:00"), 50); // Define uma reserva para as 19:00 com capacidade para 50 pessoas.

            Console.WriteLine($"Reserva às 19:00 - Capacidade: {gerenciador.FazerReserva(DateTime.Parse("2023-09-16 19:00"), 20)}");

            gerenciador.AdicionarReserva(DateTime.Parse("2023-09-16 20:00"), 40); // Define uma reserva para as 20:00 com capacidade para 40 pessoas.

            Console.WriteLine($"Reserva às 20:00 - Capacidade: {gerenciador.FazerReserva(DateTime.Parse("2023-09-16 20:00"), 30)}");
            Console.WriteLine($"Reserva às 20:00 - Capacidade: {gerenciador.FazerReserva(DateTime.Parse("2023-09-16 20:00"), 15)}");
            Console.WriteLine($"Reserva às 20:00 - Capacidade: {gerenciador.FazerReserva(DateTime.Parse("2023-09-16 20:00"), 10)}");

            gerenciador.FazerReserva(DateTime.Parse("2023-09-16 19:00"), 30); // Tentando fazer reserva para um horário que já está lotado.
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");        }
    }
}