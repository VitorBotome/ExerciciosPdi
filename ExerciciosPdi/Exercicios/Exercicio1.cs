namespace ExerciciosPdi.Exercicio1;

//Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!

public class Exercicio1
{
    public static void NomeUsuario()
    {
        Console.WriteLine("Digite o seu nome: ");
        string NomeUser = Console.ReadLine();
        Console.WriteLine($"Olá, {NomeUser}! Seja muito bem-vindo!");
    }

}
