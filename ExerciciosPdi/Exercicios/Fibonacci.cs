namespace ExerciciosPdi.Exercicios;

public class Fibonacci
{
    public static void numerosFibonacci()
    {
        Console.WriteLine("Digite a quantidade de termos da sequencia de fibonacci: ");
        int num = int.Parse(Console.ReadLine());
        int a = 0, b = 1;

        /*while(a <= 10)
        {

            Console.WriteLine(a + " ");
            int o = a;
            a = b;
            b = o + a;
            
        }*/

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(a + " ");
            int meio = a;           // a = o b = 1  -----   meio = 0   a = 1  ---  b = [a]meio + a[b]
            a = b;
            b = meio + a;
            
        }
        

    }
}
