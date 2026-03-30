namespace ExerciciosPdi.Exercicios;


/*1. Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
    - A soma entre esses dois números;
    - A subtração entre os dois números;
    - A multiplicação entre os dois números;
    - A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
    - A média entre os dois números.*/

public class Exercicio3
{
    public static void Calculadora()
    {
        Console.WriteLine("Digite dois numeros para: Somar, subtrair, multiplicar, dividir e ver a media entre os dois numero");
        Console.WriteLine("Numero 1: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Numero 2: ");
        double num2 = double.Parse(Console.ReadLine());

        double soma = num1 + num2;
        double subtracao = num1 - num2;
        double multiplicacao = num1 * num2;
        double divisao = 0;
        if (num2 != 0)
        {
            divisao = num1 / num2;
        }
        double media = (num1 + num2) / 2;

        Console.WriteLine($"Os dois numeros que voce escolheu foram {num1} e {num2}\n" +
            $" A soma entre eles é {soma:F2}\n" +
            $" A subtração é {subtracao:F2}\n" +
            $" A multiplicação é {multiplicacao:F2}\n" +
            $" {(num2 == 0 ? "Não é possível dividir por 0": $"A divisão é {divisao:F2}")}\n" +
            $" A media entre eles é {media:F2}");
    }
}
 