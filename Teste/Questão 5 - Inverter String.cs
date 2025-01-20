using System;

class Questao5
{
    public static void Executar()
    {
        Console.Write("Digite uma string para inverter: ");
        string input = Console.ReadLine();

        string inverted = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            inverted += input[i];
        }

        Console.WriteLine($"String invertida: {inverted}");
    }
}
