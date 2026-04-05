
namespace ExerciciosPdi.Exercicios;

public class Vogais
{
    public static void veificaVogais()
    {
        Console.WriteLine("Digite uma frase");
        string frase = Console.ReadLine().ToLower();
         
        int contador = 0;

        foreach (char letra in frase)
        {
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                contador++;
            }
        }
        Console.WriteLine($"A quantidade de vogais é {contador}");
            
                
    }
    
}
