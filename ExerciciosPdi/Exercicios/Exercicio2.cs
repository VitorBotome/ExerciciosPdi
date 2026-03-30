namespace ExerciciosPdi.Exercicios;

//Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.

public class Exercicio2
{
    public static void NomeSobrenome()
    {
        Console.WriteLine("Digite o seu primeiro nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o seu sobrenome");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome} {sobrenome}");

    }
}
