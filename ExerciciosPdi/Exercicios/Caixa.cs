namespace ExerciciosPdi.Exercicios;

public class Caixa
{
    public static void caixaEletronico()
    {
        Console.WriteLine("CAIXA ELETRONICO");
        Console.WriteLine("Qual valor voce quer sacar: ");
        int saldo = int.Parse(Console.ReadLine());
        
        List<int> notas = new List<int> { 100,50,20,10};
        
        
        for (int i = 0; i < notas.Count; i++)
        {
            int quantidade = saldo / notas[i];
            saldo = saldo % notas[i]; 

            if (quantidade > 0)
            {
                Console.WriteLine($"notas de {notas[i]} usadas: {quantidade}");
            }
        }


    }
}
