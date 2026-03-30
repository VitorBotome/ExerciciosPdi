namespace ExerciciosPdi.Exercicios;

//Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
public class Exercicio4
{
    public static void Palavra()
    {
        Console.WriteLine("Digite o que quiser para saber quantos caracteres a sua frase possui");
        string texto = Console.ReadLine();

        Console.WriteLine($"O texto que voce digitou tem {texto.Replace(" ", "").Count()} caracteres");
    }
}
