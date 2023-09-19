using Atividade04Ex03;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ReservaDeVoo reserva = new ReservaDeVoo(100); // Define a capacidade inicial do avião.

            Console.WriteLine($"Capacidade do avião: {reserva.Capacidade}");
            Console.WriteLine($"Assentos reservados: {reserva.AssentosReservados}");

            reserva.ReservarAssentos(30); // Reserva 30 assentos.
            Console.WriteLine($"Assentos reservados: {reserva.AssentosReservados}");

            reserva.ReservarAssentos(80); // Tenta reservar mais 80 assentos.
            Console.WriteLine($"Assentos reservados: {reserva.AssentosReservados}");
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