using Atividade04Ex10;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            MonitorDeSaude monitor = new MonitorDeSaude(120.0, 80);

            Console.WriteLine($"Pressão arterial: {monitor.PressaoArterial}");
            Console.WriteLine($"Frequência cardíaca: {monitor.FrequenciaCardiaca}");

            monitor.AtualizarSinaisVitais(110.0, 70);

            Console.WriteLine($"Pressão arterial após atualização: {monitor.PressaoArterial}");
            Console.WriteLine($"Frequência cardíaca após atualização: {monitor.FrequenciaCardiaca}");

            monitor.AtualizarSinaisVitais(140.0, 50); // Tentando atualizar com valores fora dos intervalos saudáveis
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}