namespace ExerciciosPdi.Exercicios;

public class Exercicio7
{
    public static void numeroPrimo()
    {
        Console.WriteLine("Descubra se um numero e primo: ");
        int num = int.Parse(Console.ReadLine());

        bool primo = true;

        if (num <= 1)
        {
            Console.WriteLine($"{num} não é primo!");
            return;
        }
        
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
               Console.WriteLine($"{num} não é primo!");
                primo = false;
                break;
            }
        }
        if (primo)
        {
            Console.WriteLine($"{num} é um numero primo!");
        }
    }
}
