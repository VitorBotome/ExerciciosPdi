
namespace ExerciciosPdi.Exercicios;

/*Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;

Ao final, o programa deve exibir*** Verdadeiro*** se a placa for válida e *** Falso*** caso contrário.*/

public class Exercicio5
{
    public static void PlacaVeiculo()
    {
        while(true)
        {
            Console.WriteLine("Digite a placa do Carro");
            string placa = Console.ReadLine();

            if (placa.Length == 7
                && char.IsLetter(placa[0])
                && char.IsLetter(placa[1])
                && char.IsLetter(placa[2])
                && char.IsDigit(placa[3])
                && char.IsDigit(placa[4])
                && char.IsDigit(placa[5])
                && char.IsDigit(placa[6]))
            {
                Console.WriteLine("Parabens, a placa esta seguindo o padrão brasileiro válido até 2018");
                break;
            }
            else
            {
                Console.WriteLine("A placa precisa seguir o padrão brasileiro válido até 2018:" +
                    "\n - A placa deve ter 7 caracteres alfanuméricos;" +
                    "\n    - Os três primeiros caracteres são letras(maiúsculas ou minúsculas);" +
                    "\n    - Os quatro últimos caracteres são números;");
            }
        }
    }
}
