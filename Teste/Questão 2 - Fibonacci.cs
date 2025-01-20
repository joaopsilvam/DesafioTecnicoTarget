using System;

class Questao2
{
    public static void Executar()
    {
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        int num = int.Parse(Console.ReadLine());

        if (IsFibonacci(num))
        {
            Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {num} NÃO pertence à sequência de Fibonacci.");
        }
    }

    private static bool IsFibonacci(int number)
    {
        int a = 0, b = 1;

        while (b <= number)
        {
            if (b == number)
            {
                return true;
            }

            int temp = a + b;
            a = b;
            b = temp;
        }

        return false;
    }
}
