using Atividade04Ex01;

class Program
{
    static void Main(string[] args)
    {
        EstoqueDeProdutos estoque = new EstoqueDeProdutos();

        Console.WriteLine("Bem-vindo ao sistema de controle de estoque!");

        while (true)
        {
            Console.WriteLine($"Quantidade atual de produtos em estoque: {estoque.QuantidadeProdutos}");

            Console.Write("Digite a quantidade de produtos a ser adicionada (ou negativa para sair): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int quantidade))
            {
                try
                {
                    estoque.QuantidadeProdutos += quantidade;
                    Console.WriteLine("Quantidade atualizada com sucesso!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            }

            Console.WriteLine();
        }
    }
}
