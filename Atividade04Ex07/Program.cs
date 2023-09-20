using Atividade04Ex07;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ControleDeTemperatura termostato = new ControleDeTemperatura(22);

            Console.WriteLine($"Temperatura definida: {termostato.TemperaturaDefinida}");

            termostato.TemperaturaDefinida = 25; // Define uma nova temperatura
            Console.WriteLine($"Nova temperatura definida: {termostato.TemperaturaDefinida}");

            termostato.TemperaturaDefinida = 10; // Tentando definir uma temperatura fora do intervalo permitido
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}