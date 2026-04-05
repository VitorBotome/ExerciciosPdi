
namespace ExerciciosPdi.Exercicios;

public class VerificarCpf
{
    public static void cpf()
    {
        Console.WriteLine("Digite o seu cpf");
        string cpf = Console.ReadLine();

        if (cpf.Length != 11)
        {
            Console.WriteLine("O CPF precisa ter 11 digitos");
            return;
        }

        foreach (char c in cpf)
        {
            if (!char.IsDigit(c))
            {
                Console.WriteLine("O cpf precisa ter 11 numeros. ");
                return;
            }
        }
        Console.WriteLine($"Seu cpf é valido: {cpf}");
    }
}
