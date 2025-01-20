class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a questão para executar (1, 2, 3, 4 ou 5):");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Questao1.Executar();
                break;
            case "2":
                Questao2.Executar();
                break;
            case "3":
                Questao3.Executar();
                break;
            case "4":
                Questao4.Executar();
                break;
            case "5":
                Questao5.Executar();
                break;
            default:
                Console.WriteLine("Escolha inválida.");
                break;
        }
    }
}
