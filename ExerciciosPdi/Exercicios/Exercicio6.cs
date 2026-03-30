namespace ExerciciosPdi.Exercicios;

/* Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas.
    - A data com o mês por extenso.*/

public class Exercicio6
{
    public static void DataAtual()
    {
        DateTime data = DateTime.Now;

        Console.WriteLine("Escolha o formato da data: " +
            "\n 1 - Formato completo " +
            "\n 2 - Apenas data (dd/MM/yyyy) " +
            "\n 3 - Apenas hora (24h) " +
            "\n 4 - Data com mês por extenso");
       
        int cont = int.Parse(Console.ReadLine());

        switch (cont)
        {
            case 1:
                Console.WriteLine(data.ToString("dddd, dd/MM/yyyy HH:mm:ss"));
                break;
            case 2:
                Console.WriteLine(data.ToString("dd/MM/yyyy"));
                break;
            case 3:
                Console.WriteLine(data.ToString("HH:mm:ss"));
                break;
            case 4:
                Console.WriteLine(data.ToString("dd 'de' MMMM 'de' yyyy"));
                break;
            default:
                Console.WriteLine("opção invalida");
                break;
        }
    }
}
