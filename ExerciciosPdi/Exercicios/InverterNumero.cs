
namespace ExerciciosPdi.Exercicios;

public class InverterNumero
{
    public static void inverte()
    {
        Console.WriteLine("Digite um numero para inverter: ");
        string numero = Console.ReadLine();

        char[] array = numero.ToCharArray();
        Array.Reverse(array);

        string invertido = new string(array);
        Console.WriteLine(invertido);
    }


    // num % 10
    // ivertido = invertido * 10 + num
    //
}
